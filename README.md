# Banking Application - ISE102 Assessment 2

A console-based banking application developed in C# for ISE102 Assignment 2, implementing user signup and login functionality.

## Features

### Task 1: Login Module ✅
- **Username/Password verification** with predefined test user
- **3-attempt limit** for login security
- **Error handling** for invalid credentials
- **Navigation options** after failed attempts (retry, main menu, quit)

### Task 2: Signup Module ✅
- **User registration** with required fields:
  - Username (unique)
  - Email
  - Age (validated as number)
  - Phone
  - Password
- **Field validation** - all fields must be filled
- **Duplicate username prevention**
- **Immediate login verification** after successful signup

## Demo Credentials

**Test User Account:**
- Username: `Joe.Doe`
- Password: `Password123`

## How to Run

### Prerequisites
- .NET 9.0 or later

### Running the Application
```bash
dotnet run
```

### Menu Options
1. **Login** - Sign in with existing credentials
2. **Signup** - Register a new user account
3. **Show Demo Credentials** - Display test account info
4. **Quit** - Exit the application

## Code Structure

### Classes
- **`Program`** - Main application logic and user interface
- **`Bank`** - Handles user management, login, and signup operations
- **`User`** - Data model for user information

### Key Methods
- `Bank.Login(username, password)` - Authenticates user credentials
- `Bank.SignUp(username, email, age, phone, password)` - Registers new users
- `HandleLogin()` - Manages login process with retry logic
- `HandleSignup()` - Manages user registration process

## Assessment Requirements Met

### Task 1 Requirements ✅
- [x] Bank class with login method
- [x] Takes username and password arguments
- [x] Cross-verification with registered data
- [x] Error handling for invalid credentials
- [x] 3-attempt login limit for security
- [x] Test user Joe.Doe/Password123 initialized

### Task 2 Requirements ✅
- [x] Signup method collecting all required fields
- [x] Username, Email, Age, Phone, Password validation
- [x] Empty field validation with error prompts
- [x] Login validation after successful signup
- [x] List-based storage for multiple users

## Future Enhancements (Assessment 3)
- View Balance
- Deposit functionality
- Withdraw functionality
- Transfer between accounts

## Technical Details
- **Framework:** .NET 9.0
- **Language:** C# 
- **Architecture:** Console Application
- **Data Storage:** In-memory List<User>

## Author
Developed for ISE102 - Introduction to Software Development
University of Technology Sydney (UTS)