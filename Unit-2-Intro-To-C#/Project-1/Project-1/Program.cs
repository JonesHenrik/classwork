// This is a comment - everything after slashes is ignored
/*
  This is a block comment - everything between slash asterisk is ignored
 */

// A namespace identifies a context in which a word is known
//   allows same name to be used in different contexts to mean different things
namespace Project_1;

// everything in C# is defined in a Class
//      A Class is a group of related things
// a Class starts with a class keyword
// these brackets surround blocks of code
class Program
{ // start of code for the class
    // every application has a method called main, Main() is simply where every application starts
    // a method is a self-contained set code that performs a function
    // a method may return a value and accept data to process
    // method signature identifies what the method returns its name and what it accepts
    //      return-type name(data-it-accepts)
    
    // static means there can only be one of these in the 
    
    // also known as a function or a program
    //     return
    //     type  name(data-it-accepts)
    static void  Main(string[] args)
    { // start of code for main()
        // This code will display whatever is between the ("") on screen
        
        // Console is an object defined by C# to represent the screen
        // An object has certain behaviors
        // A behavior is something an object can do with data
        // behaviors are implemented using methods
        
        // object.method(data) - object oriented programming
        //
        // when you see a . after a name, the name to the left is probably an object
        //                  name( , the name is a method
        //                  name after the ., the name is usually a method
        
     // object.method(data-for-the-method-to-process)  
        Console.WriteLine("Hello, World!"); // EVERY C# STATEMENT ENDS IN A SEMICOLON
        
    } // end of code for main()
} // end of code for the class