#include <U8g2lib.h>
#include <SPI.h>

// Define the display object
U8G2_ST7920_128X64_F_SW_SPI u8g2(U8G2_R0, /* clock=*/ 13, /* data=*/ 11, /* CS=*/ 10, /* reset=*/ 8);

void setup() {
  // Initialize the display
  u8g2.begin();
  
  // Set font and position
  u8g2.setFont(u8g2_font_ncenB14_tr);
  u8g2.setCursor(0, 20); // Adjust the position as needed
}

void loop() {
  // Clear the display
  u8g2.clearBuffer();
  
  // Write "sranie w banie"
  u8g2.print("sranie w banie");

  // Send the buffer to the display
  u8g2.sendBuffer();

  // Delay before refreshing the display
  delay(1000); // Adjust as needed
}
