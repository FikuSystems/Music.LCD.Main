#include <LiquidCrystalFast.h>
LiquidCrystalFast lcd(13, 10, 12, 8, 7, 6, 5);
String input;
String Line1 = "";
String Line2 = "";
String Line1lastState;
String Line2lastState;
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
  Serial.begin(115200);
  lcd.begin(20, 4);
  lcd.setCursor(0,0);
  lcd.print("    FikuSystems     ");
  lcd.setCursor(0,1);
  lcd.print("     MusicLCD       ");
  lcd.setCursor(0,3);
  lcd.print("GitHub:  FikuSystems");
  delay(1000);
  displayMainScreen();
}

void loop() {
  if (connected) {
    if (millis() - previousMillisOut >= 5000 && !timeoutReached) {
      displayDisconnectScreenError();
      connected = false;
      Line1 = "";
      Line2 = "";
      timeoutReached = true; // Set the flag to true when timeout is reached
    }
  }
  scrollLine1();
  if (Serial.available() > 0 && !connected) {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("      MusicLCD"      );
    previousMillisOut = millis(); // Reset the timeout
    timeoutReached = false; // Reset the timeout reached flag
    connected = true;
    String version = " V:0.0.0.4";
    String codeType = "T:BCS";
    Serial.println(codeType + version);
    firstConnect = true;
    delay(70);
  } else if (Serial.available() > 0 && connected) {
    previousMillisOut = millis(); // Reset the timeout
    timeoutReached = false; // Reset the timeout reached flag
    input = "";
    input = Serial.readString();
    delay(1);
    if(input.indexOf(">1") > 0 && input.indexOf(">2") > 0) {

      if(firstConnect) {
        firstConnect = false;
        input = "";
        lcd.clear();
        lcd.setCursor(0, 0);
        lcd.print("      MusicLCD"      );
      }

      Line1 = input.substring(0, input.indexOf(">1"));
      Line2 = input.substring(input.indexOf(">1") + 2, input.indexOf(">2"));

      if (Line1 != Line1lastState) {
        scrollPosition = 0;
        lcd.setCursor(0, 1);
        lcd.print("                    ");
        lcd.setCursor(0, 1);
        if (Line1.length() > 19) {
          lcd.print(Line1.substring(0, 20));
        } else {
          lcd.print(Line1);
        }
      }
      if (Line2 != Line2lastState && Line2 != "D*I^S$C)O%N#E%C&T") {
        lcd.setCursor(0, 2);
        lcd.print("                    ");
        lcd.setCursor(0, 2);
        if (Line2.length() > 19) {
          lcd.print(Line2.substring(0, 20));
        } else {
          lcd.print(Line2);
        }
      } else if (Line2 == "D*I^S$C)O%N#E%C&T") {
        displayDisconnectScreen();
      }
    }

  }

    Line1lastState = Line1;
    Line2lastState = Line2;
}

void displayDisconnectScreen() {

  lcd.clear();
  lcd.setCursor(0,0);
  delay(50); 
  lcd.print("    Disconnected    ");
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
  delay(50); 
  lcd.print("    Disconnected    ");
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
  lcd.print("   Connect Wizard   ");
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
    lcd.setCursor(0, 1);
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
    lcd.setCursor(0, 2);
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