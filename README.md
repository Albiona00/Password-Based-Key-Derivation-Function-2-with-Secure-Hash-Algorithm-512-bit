# Password-Based-Key-Derivation-Function-2-with-Secure-Hash-Algorithm-512-bit
Overview

This project implements PBKDF2-SHA512, a secure password hashing algorithm. It provides a user-friendly Windows Forms interface for generating and comparing secure password hashes. The implementation allows customization of key derivation parameters for enhanced security.

Features
Secure Password Hashing with PBKDF2-SHA512
Configurable Algorithm Parameters
User-Friendly Windows Forms Interface

Usage
Enter the username and password.
Click "Login" to generate a secure derived key.
The derived key is displayed for storage or comparison.

Functional Code Summary
The main functionality of the application is implemented in the Form1 class. Key components include:

Salt Generation: The GenerateSalt method creates a random salt of a specified length.
Derived Key Generation: The GenerateDerivedKey method uses the Rfc2898DeriveBytes class to derive a key from the password, salt, iterations, and the SHA-512 hashing algorithm.
Login Button Click Event: Handles the button_login_Click event, capturing the entered username and password, generating a derived key, and displaying it in a message box.

// Example parameters
byte[] salt = GenerateSalt();
int iterations = 10000; // Number of iterations (adjust according to your security requirements)
int derivedKeyLength = 64; // 64 bytes for SHA-512

// Generate the derived key using PBKDF2-SHA512
byte[] derivedKey = GenerateDerivedKey(password, salt, iterations, derivedKeyLength);

// Convert the derived key to a hex string for storage or comparison
string derivedKeyHex = BitConverter.ToString(derivedKey).Replace("-", "");

// For testing purposes, you can display the derived key in a message box
MessageBox.Show("Login Successful!\nDerived Key (Hex): " + derivedKeyHex, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


Contributors

Albiona Vukaj and Rina Shabani
