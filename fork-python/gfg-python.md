# Python

Python is a widely used general-purpose, high level programming language. Python is a programming language that lets you work quickly and integrate systems more efficiently.

```
print("Hello Python World!")
```


## Why Python is becoming popular?

1. ease of writing
2. fewer line of code
3. python supports functional programming or object oriented programming
4. Simplicity is the best

## Language features

- Interpreted
- platform independent
- free and open source
-  high level language
- simple
- robust
- embeddable
- rich in library

### Difference between Python & Java
| Python | Java |
| :------------- | :------------- |
| **Dynamically Typed**1.No need to declare anything. An assignment statement binds a name to an object, and the object can be of any type.      | 1.All variable names (along with their types) must be explicitly declared. Attempting to assign an object of the wrong type to a variable name triggers a type exception.      |
|.2.No type casting required when using container objects   |2.Type casting is required when using container objects   |
|**Concise** Express much in limited words   | 	**Verbose** Contains more words  |
|Compact   |   Less Compact|
|Uses Indentation for structuring code   | Uses braces for structuring code  |

### Similarity with Java
- Require some form of runtime on your system (JVM/Python runtime)
- Can probably be compiled to executables without the runtime (this is situational, none of them are designed to work this way)

### Python Uses
- Used In Artificical Intelligence
- Used in Data Science
- Used in Machine LEarning

### Advantages
- Easy to use
- Multi-programming paradigm
-  Presence of third-party modules
- Extensive support libraries(NumPy for numerical calculations, Pandas for data analytics etc)
- Open source and community development
- Easy to learn
- User-friendly data structures
- High-level language
- Dynamically typed language(No need to mention data type based on value assigned, it takes data type)
- Object-oriented language
- Portable and Interactive
- Portable across Operating systems

### Disadvantages
- Slow
- Absence from mobile computing and browsers
- indentation is irritating


### Applications :
    1) GUI based desktop applications(Games, Scientific Applications)
    2) Web frameworks and applications
    3) Enterprise and Business applications
    4) Operating Systems
    5) Language Development
    6) Prototyping

### Organizations using Python :
    1) Google(Components of Google spider and Search Engine)
    2) Yahoo(Maps)
    3) YouTube
    4) Mozilla
    5) Dropbox
    6) Microsoft
    7) Cisco
    8) Spotify
    9) Quora

### variables and Data structures
- number (int,float, decimal, complex)
- boolean
- string
- 4 built in Data structures
  - List
  - Tuples
  - Sets
  - Dictionary

### Input and Output
- input() for Input
- Print() for output

```
# Python program to illustrate
# getting input from user
name = input("Enter your name: ")

# user entered the name 'Arun'
print("hello", name)
```

```
# Python3 program to get input from user
# accepting integer from the user
# the return type of input() function is string ,
# so we need to convert the input to integer
num1 = int(input("Enter num1: "))
num2 = int(input("Enter num2: "))

num3 = num1 * num2
print("Product is: ", num3)

```

### selection statement

- if statement

```
# Python program to illustrate
# selection statement

num1 = 34
if(num1>12):
    print("Num1 is good")
elif(num1>35):
    print("Num2 is not gooooo....")
else:
    print("Num2 is great")
```

### Functions

Syntax:
**def function_name(parameter):**
Function body

```
# Python program to illustrate
# functions
def hello():
    print("hello")
    print("hello again")
hello()

# calling function
hello()               
```

Now as we know any program starts from a 'main' function...lets create a main function like in many other programming languages.
```
# Python program to illustrate
# function with main
def getInteger():
    result = int(input("Enter integer: "))
    return result

def Main():
    print("Started")

    # calling the getInteger function and
    # storing its returned value in the output variable
    output = getInteger()     
    print(output)

# now we are required to tell Python
# for 'Main' function existence
if __name__=="__main__":
    Main()

```
### iterations

for i in items:
for i in range(num):
for idx,item in enumerate(s)

```
for step in range(5):    
    print(step)

```
###  modules

Import modules using Import
```
import math

def Main():
    num = float(input("Enter a number: "))

    # fabs is used to get the absolute value of a decimal
    num = math.fabs(num)
    print(num)
if __name__=="__main__":
    Main()

```

## Operators

### Arithmetic

| Operator |Description     | Syntax|
| :------------- | :------------- | :-------------|
| + Addition      | adds two operands       | x+y|
| - Substraction   |substracts two operands   |x-y   |
|* Multiplication   |multiplies two operands   |x*y   |
|/ Division(float)   |divides first by second operand   |x/y   |
|//Division(int)   |divides first by second operand   |x//y   |
|%modulus   | returns reminder when first divides second  |x%y   |
|** power   |returns first raised to power second   |x**y   |

### Relational

| Operator |Description     | Syntax|
| :------------- | :------------- | :-------------|
|>   | greather than  |x>y   |
|<   |less than   |x<y   |
|==   |equals   |x==y   |
|!=   |not equals   |x!=y   |
|>=   |greater than or equal to   |x>=y   |
|<=   |less than or equal to   |x<=y   |

### logical

| Operator |Description     | Syntax|
| :------------- | :------------- | :-------------|
|and   |logical and   | a and b   |
|or   |logical or   |a or b   |
|not   |logical negation   | not a   |

### BitWise

| Operator |Description     | Syntax|
| :------------- | :------------- | :-------------|
