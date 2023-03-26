int LED = D7; // Initalising the led2 as the D7 led on the board
int button = D3; // Initalising the button as the D3 pin on the board


void setup() {
    
    pinMode(button, INPUT_PULLUP);
    pinMode(LED, OUTPUT); // seting pin D7 as the output (no inputs)

}


// - a dot lasts for 1 second
void dot () {
  digitalWrite(LED, HIGH); // /
  delay(1000); 
}

// - a space lasts for 1 second (between dot and dash too)
void space () {
  digitalWrite(LED, LOW); 
  delay(1000); 
}

// - dash lasts for 3 seconds
void dash () {
  digitalWrite(LED, HIGH); // -
  delay(3000); 
}

// - space between character is 3 dots duration
void newChar () {
  digitalWrite(LED, LOW); // -
  delay(3000); 
}



void loop() {
    
  
  // Kailas = -.- .- .. .-.. .- ...
  
    int buttonState = digitalRead(button);
    
    if (buttonState == HIGH) {
    // K = -.-
    dash(); 
    space();
    dot();
    space();
    dash();
    
    // A = .-
    newChar();
    dot();
    space();
    dash();
    
    // I = ..
    newChar();
    dot();
    space();
    dot();
    
    // L = .-..
    newChar();
    dot();
    space();
    dash();
    space();
    dot();
    space();
    dot();
    
    // A = .-
    newChar();
    dot();
    space();
    dash();
    
    // S = ...
    newChar();
    dot();
    space();
    dot();
    space();
    dot();
    space();
    }
  
}
