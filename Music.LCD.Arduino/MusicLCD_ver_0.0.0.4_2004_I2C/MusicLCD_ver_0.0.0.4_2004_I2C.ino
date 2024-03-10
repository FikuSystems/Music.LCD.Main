#include <LiquidCrystal_I2C.h>
#include <Wire.h>
#include <EEPROM.h>

#define Buzzer 11
#define BACK_PIN 4
#define PLAY_PAUSE_PIN 3
#define FORWARD_PIN 2

//define custom progressBar
const byte customChar0[] = {
  0x00,
  0x07,
  0x0C,
  0x08,
  0x08,
  0x0C,
  0x07,
  0x00
};
const byte customChar1[] = {
  0x00,
  0x07,
  0x0C,
  0x0B,
  0x0B,
  0x0C,
  0x07,
  0x00
};
const byte customChar2[] = {
  0x00,
  0x1F,
  0x00,
  0x00,
  0x00,
  0x00,
  0x1F,
  0x00
};
const byte customChar3[] = {
  0x00,
  0x1F,
  0x00,
  0x1F,
  0x1F,
  0x00,
  0x1F,
  0x00
};
const byte customChar4[] = {
  0x00,
  0x1C,
  0x06,
  0x02,
  0x02,
  0x06,
  0x1C,
  0x00
};
const byte customChar5[] = {
  0x00,
  0x1C,
  0x06,
  0x1A,
  0x1A,
  0x06,
  0x1C,
  0x00
};
const byte customChar6[] = {
  B01110,
  B10001,
  B10101,
  B10001,
  B10101,
  B10101,
  B10001,
  B01110
};

//voids for sound and screens



LiquidCrystal_I2C lcd(0x27,20,4); 
//unfortunetly it needs to be global for experimentla function
String Line1 = "";
String Line2 = "";
String Line1lastState;
String Line2lastState;
String Line3lastState;
String Line4lastState;
int SerialTimeOut;
String outDataLastState;
bool progress[20];
bool progresslastState[20];
bool firstConnect = false;
bool connected = false;
unsigned long previousMillisOut = 0;
bool timeoutReached = false;
//for fucking experimental function don't fucking touch unles it couse problem then delete everything fucking fuck fuck
unsigned long previousMillis = 0;  // Stores the last time the function was executed
int scrollPosition = 0;             // Current position of the scrolling text
int scrollPosition1 = 0;
bool restartScroll = false;
bool restartScroll1 = false;          // Flag to indicate if scrolling should restart
unsigned long restartDelay = 4000; // Two-second delay in milliseconds for restarting scrolling
unsigned long restartMillis = 0;    // Stores the time when scrolling should restart
//fuck this shit it won't work
//oh fuck, it says done compiling, probably bc i didn't use any function using those variables

void setup() {
  Wire.begin();
  Wire.setClock(400000);
  lcd.init();                      
  lcd.init();
  lcd.backlight();
  lcd.home();
  lcd.setCursor(0,0);
  lcd.print("    FikuSystems     ");
  lcd.setCursor(0,1);
  lcd.print("     MusicLCD       ");
  lcd.setCursor(0,3);
  lcd.print("GitHub:  FikuSystems");
  playStartupSound();
  delay(1000);
  lcd.clear();
  
  Serial.begin(500000);
  lcd.createChar(0, customChar0);
  lcd.createChar(1, customChar1);
  lcd.createChar(2, customChar2);
  lcd.createChar(3, customChar3);
  lcd.createChar(4, customChar4);
  lcd.createChar(5, customChar5);
  lcd.createChar(6, customChar6);
  pinMode(11, OUTPUT);
  pinMode(9, INPUT_PULLUP);
  pinMode(4, INPUT_PULLUP);
  pinMode(3, INPUT_PULLUP);
  pinMode(2, INPUT_PULLUP);
  // Enable pin change interrupt for pin 4 (PCINT20)
  PCICR |= (1 << PCIE2); // Enable PCINT23:16 pin change interrupt
  PCMSK2 |= (1 << PCINT20); // Enable pin change interrupt for PCINT20

  attachInterrupt(digitalPinToInterrupt(FORWARD_PIN), checkButtons, CHANGE);
  attachInterrupt(digitalPinToInterrupt(PLAY_PAUSE_PIN), checkButtons, CHANGE);
  displayMainScreen();
  if (EEPROM.read(0) == 0) {
    tone(Buzzer, 1400); 
    delay(150); 
    noTone(Buzzer);
    delay(40); 
    tone(Buzzer, 1400); 
    delay(600); 
    noTone(Buzzer);
  }
  
}

void playStartupSound() {
  if(EEPROM.read(0) == 0) {
    tone(Buzzer, 500); 
    delay(200); 
    noTone(Buzzer);
    tone(Buzzer, 1000); 
    delay(200); 
    noTone(Buzzer);
    tone(Buzzer, 800); 
    delay(200); 
    noTone(Buzzer);
  }
        

}
void playDisconnectSound() {
  if(EEPROM.read(0) == 0) {
    tone(Buzzer, 1000); 
    delay(200); 
    noTone(Buzzer);
    delay(1); 
    tone(Buzzer, 500); 
    delay(200); 
    noTone(Buzzer);
  }
  
}
void playConnectSound() {
  if(EEPROM.read(0) == 0) {
    tone(Buzzer, 500);
    delay(200);
    noTone(Buzzer);
    tone(Buzzer, 1000);
    delay(200);
    noTone(Buzzer);
  }
  
  lcd.clear();
  lcd.setCursor(0,1);
  lcd.print(" Connection found!  ");
  lcd.setCursor(0,2);
  lcd.print("   Please wait...   ");
}
void displayDisconnectScreen() {

  lcd.clear();
  lcd.setCursor(0,0);
  lcd.write(6);
  delay(50); 
  lcd.print("   Disconnected   ");
  delay(50); 
  lcd.write(6);
  delay(50); 
  lcd.setCursor(0,1);
  lcd.print("                    ");
  delay(50); 
  lcd.setCursor(0, 2);
  lcd.print("Display Disconnected");
  delay(50); 
  lcd.setCursor(0, 3);
  lcd.print("                    ");
  delay(1000);
  displayMainScreen();
}
void displayDisconnectScreenError() {

  lcd.clear();
  lcd.setCursor(0,0);
  lcd.write(6);
  delay(50); 
  lcd.print("   Disconnected   ");
  delay(50); 
  lcd.write(6);
  delay(50); 
  lcd.setCursor(0,1);
  lcd.print("                    ");
  delay(50); 
  lcd.setCursor(0, 2);
  lcd.print(" Internal Exception ");
  delay(50); 
  lcd.setCursor(0, 3);
  lcd.print("                    ");
  delay(1000);
  displayMainScreen();
}
void displayMainScreen() {

  lcd.write(6);
      delay(100); 
  lcd.print("  Connect Wizard  ");
      delay(100); 
  lcd.write(6);
      delay(100); 
  lcd.setCursor(0,1);
      delay(100); 
  lcd.print("                    ");
      delay(100); 
  lcd.setCursor(0, 2);
      delay(100); 
  lcd.print(" Please tap connect ");
      delay(100); 
  lcd.setCursor(0, 3);
      delay(100); 
  lcd.print("  in Music LCD PRG  ");
}

void loop() {
  if (connected) {
    if (millis() - previousMillisOut >= 5000 && !timeoutReached) {
      displayDisconnectScreenError();
      playDisconnectSound();
      connected = false;
      Line1 = "";
      Line2 = "";
      timeoutReached = true; // Set the flag to true when timeout is reached
    }
  }
  StartPrintingData();
  scrollLine1();
}

void checkButtons() {

 
  String tmp = String(digitalRead(BACK_PIN)) + String(digitalRead(PLAY_PAUSE_PIN)) + String(digitalRead(FORWARD_PIN));

  if (tmp != outDataLastState && connected) {
    Serial.println(tmp);
  }
  outDataLastState = tmp;
}

//worse Interrupt than on pin 2 and 3 but it works on pin 4 (forward button)
ISR(PCINT2_vect) {
  // Check if the interrupt is from pin 4
  if (bitRead(PINB, 4) == LOW) {
    checkButtons();
  }
}
//printing progress bar one character, used in other void
void printChar(int LCDPosition, int state) {
  if (LCDPosition == 0) {
    lcd.setCursor(0, 3);
    if (state == 0) {
      lcd.write(0);
    } else if (state == 1) {
      lcd.write(1);
    }
  } else if (LCDPosition > 0 && LCDPosition < 19) {
    lcd.setCursor(LCDPosition, 3);
    if (state == 0) {
      lcd.write(2);
    } else if (state == 1) {
      lcd.write(3);
    }
  } else if (LCDPosition == 19) {
    lcd.setCursor(19, 3);
    if (state == 0) {
      lcd.write(4);
    } else if (state == 1) {
      lcd.write(5);
    }
  }
}
//printing full if needed
void lcdPrintFullBar() {
  for (int i = 0; i < 20; i++) {
    lcd.setCursor(i, 3);
    if (i == 0 && progress[0] == 0) {
      lcd.write(0);
    } else if (i == 0 && progress[0] == 1) {
      lcd.write(1);
    } else if (i == 19 && progress[19] == 0) {
      lcd.write(4);
    } else if (i == 19 && progress[19] == 1) {
      lcd.write(5);
    }
    if (i > 0 && i < 19) {
      if (progress[i] == 0) {
        lcd.setCursor(i, 3);
        lcd.write(2);
      } else if (progress[i] == 1) {
        lcd.setCursor(i, 3);
        lcd.write(3);
      }
    }
  }
}
//printig every single line of lcd if they're not the same as before
void StartPrintingData() {
  String input = "";
  String Line3 = "";
  String Line4 = "";
  String Line5 = "";
  if (Serial.available() > 0 && !connected) {
    previousMillisOut = millis(); // Reset the timeout
    timeoutReached = false; // Reset the timeout reached flag
    connected = true;
    String version = " 0.0.0.4";
    String codeType = "I2C 20x4 ";
    Serial.println(codeType + version);
    playConnectSound();
    firstConnect = true;
    delay(70);
  } else if (Serial.available() > 0 && connected) {
    previousMillisOut = millis(); // Reset the timeout
    timeoutReached = false; // Reset the timeout reached flag
    input = "";
    Line4lastState = "....................";
    input = Serial.readString();
    delay(1);
    if(input.indexOf(">1") > 0 && input.indexOf(">2") > 0 && input.indexOf(">3") > 0 && input.indexOf(">4") > 0) {

      if(firstConnect) {
        firstConnect = false;
        input = "";
        lcd.clear();
      }

      Line1 = input.substring(0, input.indexOf(">1"));
      Line2 = input.substring(input.indexOf(">1") + 2, input.indexOf(">2"));
      Line3 = input.substring(input.indexOf(">2") + 2, input.indexOf(">3"));
      Line4 = input.substring(input.indexOf(">3") + 2, input.indexOf(">4"));
      Line5 = input.substring(input.indexOf(">4") + 2, input.length());

      if(Line5 != "") {

        if(Line5.substring(2,4) == "11") {
          if(Line5.substring(0,1) == "1") {
            EEPROM.write(0, 1);

          } else if (Line5.substring(0,1) == "0") {
            EEPROM.write(0, 0);
          }
        }
      }


      if (Line1 != Line1lastState) {
        scrollPosition = 0;
        lcd.setCursor(0, 0);
        lcd.print("                    ");
        lcd.setCursor(0, 0);
        if (Line1.length() > 19) {
          lcd.print(Line1.substring(0, 20));
        } else {
          lcd.print(Line1);
        }
      }
      if (Line2 != Line2lastState) {
        lcd.setCursor(0, 1);
        lcd.print("                    ");
        lcd.setCursor(0, 1);
        if (Line2.length() > 19) {
          lcd.print(Line2.substring(0, 20));
        } else {
          lcd.print(Line2);
        }
      }
      if (Line3 != Line3lastState && Line3 != "Disconnect request") {
        lcd.setCursor(0, 2);
        lcd.print("                    ");
        lcd.setCursor(0, 2);
        lcd.print(Line3);
        
      } else if (Line3 != Line3lastState && Line3 == "Disconnect request") {
        //disconnect screen
        playDisconnectSound();
        displayDisconnectScreen();
        connected = false;
      }
      if (Line4.length() < 5) {
        if (Line4lastState.length() > 5) {
          lcdPrintFullBar();
        }
        if (Line4 != Line4lastState) {
          for (int i = 0; i < Line4.toInt(); i++) {
            progress[i] = 1;
          }
          for (int i = 19; i >= Line4.toInt(); i--) {
            progress[i] = 0;
          }
          for (int i = 0; i < 20; i++) {
            if (progress[i] != progresslastState[i]) {
              printChar(i, progress[i]);
            }
          }
        }
      } else if (Line4 == "Disconnect") {
        playDisconnectSound();
        displayDisconnectScreen();
        connected = false;
      } else {
        lcd.setCursor(0, 3);
        lcd.print("                    ");
        lcd.setCursor(0, 3);
        lcd.print(Line4);
      }
    }

  }

    Line1lastState = Line1;
    Line2lastState = Line2;
    Line3lastState = Line3;
    Line4lastState = Line4;
    for (int i = 0; i < 20; i++) {
      progresslastState[i] = progress[i];
    }
  
}





//experimental shit using fucking Milis() DON'T TOUCH DICK
void scrollLine1() {
   unsigned long currentMillis = millis();

  // Check if it's time to execute the function
  if (currentMillis - previousMillis >= 1000) {
    // Save the last time the function was executed
    previousMillis = currentMillis;

    // Call your function here
    scrollTextFromLine1();
    scrollTextFromLine2();
  }
}


void scrollTextFromLine1() {
  // Print the scrolling text
  if(Line1.length() > 20) {
    lcd.setCursor(0, 0);
    String Line1tmp = Line1 + "    ";
    if (Line1tmp.length() > scrollPosition + 20) {
      lcd.print(Line1tmp.substring(scrollPosition, scrollPosition + 20));
    } else {
      int tmpScrollPosition = Line1tmp.length() - scrollPosition;
      String tmpData = Line1tmp.substring(scrollPosition, Line1tmp.length()) + Line1.substring(0, 20 - tmpScrollPosition);
      lcd.print(tmpData);
    }
    // Increment scroll position
    scrollPosition++;

    // Check if reached end of the line
    if (scrollPosition >= Line1tmp.length()) {
      // Set scroll position to start
      scrollPosition = 0;
      // Set flag to restart scrolling with delay
      restartScroll = true;
      // Record the time when scrolling should restart
      restartMillis = millis() + restartDelay;
    }

    // Check if flag is set to restart scrolling with delay
    if (restartScroll && millis() >= restartMillis) {
      // Reset flag
      restartScroll = false;
    }
  }
}

void scrollTextFromLine2() {
  // Print the scrolling text
  if(Line2.length() > 20) {
    lcd.setCursor(0, 1);
    String Line1tmp = Line2 + "    ";
    if (Line1tmp.length() > scrollPosition1 + 20) {
      lcd.print(Line1tmp.substring(scrollPosition1, scrollPosition1 + 20));
    } else {
      int tmpScrollPosition = Line1tmp.length() - scrollPosition1;
      String tmpData = Line1tmp.substring(scrollPosition1, Line1tmp.length()) + Line2.substring(0, 20 - tmpScrollPosition);
      lcd.print(tmpData);
    }
    // Increment scroll position
    scrollPosition1++;

    // Check if reached end of the line
    if (scrollPosition1 >= Line1tmp.length()) {
      // Set scroll position to start
      scrollPosition1 = 0;
      // Set flag to restart scrolling with delay
      restartScroll1 = true;
      // Record the time when scrolling should restart
      restartMillis = millis() + restartDelay;
    }

    // Check if flag is set to restart scrolling with delay
    if (restartScroll1 && millis() >= restartMillis) {
      // Reset flag
      restartScroll1 = false;
    }
  }
}