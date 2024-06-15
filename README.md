# Student-Teacher Application

## Objective
The objective of this assignment is to assess understanding of fundamental concepts in object-oriented programming, specifically focusing on classes, objects, inheritance, and encapsulation in the context of C#.

## Overview
This application demonstrates the use of basic object-oriented programming concepts in C#. It includes implementations of `Student` and `Teacher` classes, showcasing class inheritance, encapsulation, and basic validation.

## Features
- **Class and Objects**: Implementation of a `Student` class with fields for student ID, first name, last name, and grade. The class includes both a default constructor and a parameterized constructor.
- **Inheritance**: A `Teacher` class that inherits from the `Student` class, adding a new field for the subject taught by the teacher.
- **Encapsulation**: Private fields in the `Student` class with public properties for accessing and setting values, including validation for the `grade` property to ensure it falls within a valid range (0 to 100).
- **Application**: A console application that allows users to create `Student` and `Teacher` objects and displays their details.

## Usage
1. Run the application.
2. Follow the on-screen prompts to create a student:
   - Enter student ID, first name, last name, and grade.
3. Follow the on-screen prompts to create a teacher:
   - Enter teacher ID, first name, last name, and subject.
4. The application will display the details of both the student and teacher, and show a message indicating the subject being taught by the teacher.

## Implementation Details
- The `Student` class includes methods for displaying student details.
- The `Teacher` class, derived from `Student`, includes an additional field for `subject` and a method `Teach()` to display a teaching message.
- User input is validated for integer and double values where appropriate, with prompts repeated until valid input is received.