# Eucyon Foundation Retake Exam

## Getting Started

- **Fork** this repository under your own account
- Clone your forked repository to your computer
- Create a `.gitignore` file so generated files won't be committed
- Commit your progress frequently and with descriptive commit messages
- All your answers and solutions should go in this repository
- Take care of style guide
- Take care of the naming of classes, fields, variables, files, etc.

## Keep in mind

- You can use any resource online, but **please work individually**

- **Don't just copy-paste** your answers and solutions,
  you need to understand every line of your code
- **Don't push your work** to GitHub until your mentor announces
  that the time is up
- At the end of the exam push your solution to **GitHub**


<details>
  <summary><h3>C# specific information</h3></summary>  
- Follow the C# naming convention
</details>


## Exercises

### Unique numbers

Write a method / function called `getUniqueNumbers()` which takes a square `2D array / matrix` containing integer numbers as a parameter.
It returns the numbers in a list / array without any duplication.

Write 2 different unit test cases for the method.

#### Example 1

Input

```text
[
  [1, 1],
  [4, 2]
]
```

Return value

```text
[1, 4, 2]
```

#### Example 2

Input

```text
[
  [4, 3, -1],
  [10, 2, 5],
  [-2, 3, 4]
]
```

Return value

```text
[4, 3, -1, 10, 2, 5, -2]
```

### A66 office entering

Write a method called `getA66ChipUsage()` which can read and parse a file containing information about
the chip usage at A66. The path to the file is passed as a parameter.
The method returns how many times a chip was used at the main door: *`(A66 - 04 FÕBEJÁRAT (F-1) Door #1)`*.

The return type is:

- C# Dictionary
- Java HashMap
- TS Object
 
During the development you will need only two fields from the file:

- Description #1 - the used door
- Card number

If the method can not read the file catch the error / exception and print the following message to the console:
- `A problem occurred with reading the file.`

#### Example

[Example file can be found here.](./logs.csv)

Each line represents an entry and contains the following information:

| Id  | Date and Time  | Event message  | Event Number  | Object #1  | Description #1  |  Object #2 | Description #2  | Object #3  | Description #3  | Object #4  | Description #4 |  Card number |
|---|---|---|---|---|---|---|---|---|---|---|---|---|
| 1  |  2019.01.02 9:21:49  | Access granted |  203 | 12  |   A66 - 04 FÕBEJÁRAT (F-1) Door #1  |  5 | Czender András | 0  |   |  0  |  | 00215:09895  |



Return value

```js
{
  ...,
  '00088:56736': 3,
  '00247:27091': 2,
  '00038:28945': 2,
  '00155:46240': 1,
  '00089:01168': 2,
  '00042:36689': 1,
  '00153:30309': 1
}
```

### Restaurant

Your task is to create a program to model the every day life in a restaurant.

#### Employee

- Every employee has a `name`, an `experience` (number) and a method `work()`

- The `experience` starts from `1` by default if it is not provided

- Every employee is able to `work()`, 
  however the specific method is different for every kind of employee

**We cannot hire or create basic employees** because they are always
be some kind of specific employees like `Chef`, `Manager` or `Waiter`.

##### Waiter 

- Waiter stores the amount of `tips` which is `0` by default

- Whenever it is instructed to `work()`:

  - It increases the amount of `tips` by `1`
  - It increases its `experience` by `1`

##### Chef

- Chef stores information about the `meals` it ever cooked
  - Unique names of the meals and the amount of times they were cooked

- Whenever it is instructed to `work()`:

  - It increases its `experience` by `1`

- It has a `cook()` method

  - The method gets the `mealName` as a parameter

  - The method updates the `meals` information so 
    we are able to track that it cooked this specific meal again
    
  - The method should invoke the `work()` method

##### Manager

- Manager has a `moodLevel` which is `400` by default

- Whenever `meeting()` is invoked, the `moodLevel`
  decreases by the manager's `experience`

- Whenever it is instructed to `work()`:

  - It increases the `experience` by `1`
  - It invokes its `meeting()` method
  
 #### Restaurant

- Every restaurant has a `name`, the year it was `founded`
  and a list of `employees` who are working there.

- It has a method `guestsArrived()` which instructs all employees to `work()`

- It is able to `hire()` which adds an employee to the list of `employees`
  - The employee to hire is passed as a parameter to the method


## Command line exercise

- Take a look at this directory structure:

```text
restaurant
 |--storage
 |   |--.git
 |   |--drygoods.csv
 |   |--vegnfruit.csv
 |   |--chilledprods.csv
 |   └--acount
 |       |--2019-sum.csv
 |       └--2020-sum.csv
 └--delivery
     |--drivers
     |   └--john-working-hours.csv
     |--jessica-working-hours.csv
     └--account
         └--2019-sum.csv
```

- Your task is to write commands in the correct order from the directory given below.
- Do it with the smallest number of commands possible without chaining them together.
- Assume that the following file is currently in the staging area:
  - `storage/acount/2020-sum.csv`
  - `storage/acount/2019-sum.csv`
- Your current directory is `storage/`
  1. Remove every file from the staging area
  1. Rename `storage/acount` to `storage/account`
  1. Commit the changes
  1. Make the `delivery` directory into a Git repository
  1. Move `delivery/jessica-working-hours.csv` file to `delivery/drivers` directory
  1. Delete the last 2 lines from `delivery/drivers/john-working-hours.csv`

- Solution:

```text
git restore --staged .
mv .storage/acount .storage/account
git add .
git commit -m "rename acount to account"
git init ../delivery/
mv ../delivery/jessica-working-hours.csv ../delivery/drivers
hean -n -2 ../delivery/drivers/john-working-hours.csv/

```
