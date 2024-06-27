# Remindr 🚀
Coded in collaboration with Xuli Ma ([@XULIM](https://github.com/XULIM) on GitHub)

## App Contributions 

- **Carson:**
  - 📄 Formal document, UML diagrams, part of C# for WPF, error resolution, part of Task class, app beautification.
  
- **[Xuli Ma](https://github.com/XULIM):**
  - 🖼️ WPF GUI, some background methods, part of Task class, GenerateReport window, Save & Load.

# Project Description

> This project is a simple personal agenda designed to meet the basic needs of anyone. Instead of relying on a physical notepad and pen, users can access their personal agenda on their computer, making it especially convenient for those working in the tech industry. The current features of the project include:

- **List of Tasks and Dates**
  - 📅 A list displaying the user's tasks and deadlines. By default, they are unsorted.

- **Organize Your Daily Activities**
  - 📋 A "Sort" button that, when clicked, arranges tasks chronologically (by date, soonest first, latest last).

- **Generate Report for Tasks Due Today**
  - 📝 A button that, when clicked, pops up a new window showing tasks and notes due today.

- **Generate Report for Overdue Activities**
  - ⏰ A button that, when clicked, displays a new window with the task's name, notes, and due date.

- **Save and Load**
  - 💾 Save button: Saves tasks and data to a project file.
  - 📂 Load button: Checks for the file's existence; if not, prompts the user with a message like "You have not saved previously."

- **Notes for a Task**
  - 🗒️ A section for users to write notes about their tasks. Notes are optional.

- **Set a Deadline for the Activity**
  - 📆 A calendar for setting the task's due date. If no date is provided, it won't be added.

# Development Approach

## Problem Comprehension
- 🤔 Reviewed project information and requirements to understand the task.

## Analysis, Identifying Concepts
- 🔍 Considered the elements necessary for completing the project and identified parameters to meet project requirements.

## Define Requirements and Results
- 📝 Determined data types and functions needed for executing features.

## Design a Strategy
- 🧩 Outlined desired features and graphical interface before sketching the GUI.

## Research and Modification
- 📚 Explored references like Microsoft's To-Do and simple notepad tools for inspiration.

## Testing
- 🔧 Due to the simplicity of XAML and the background code, testing focused on design preferences and trial-and-error.

# OOP Design

> For this straightforward project, we implemented two classes:

1. **XAML.cs Class**
   - 🎨 Responsible for GUI functionality to give purpose to the graphical interface.

2. **Task Class**
   - 📋 Allows users to create planned tasks with constructors for various cases: task name only, task name and due date, or name, due date, and note. This class facilitates all desired functionalities in the program.

# Screenshots 📸

*If you would like a more detailed version, here is an [imgur](https://imgur.com/a/0uMokn2) with some more screenshots*


## Default Screen

> 🏠 Landing page.

![defaultScreen](https://github.com/carsonSgit/Remindr/assets/92652800/64623687-7a39-4764-a57e-35026abcd1d0)

## Filled-in Task

> 📝 All fields function as needed. 

![filledInTask](https://github.com/carsonSgit/Remindr/assets/92652800/978dd46c-ed72-4d7e-8f4f-a444e74811ce)

## Save Tasks

> 💾 For here, we save the data in the current task list in a CSV file.

![clickSave](https://github.com/carsonSgit/Remindr/assets/92652800/f9c7d5de-b072-4886-aa3e-79144cdf5f1d)

![fileExplorer](https://github.com/carsonSgit/Remindr/assets/92652800/95974e62-a5a2-45ad-a0bc-f58f0f5262ea)

## Load Tasks

> 📂 To load a task list, we simply click the Load button and it prompts us to select a saved CSV.

![clickLoad](https://github.com/carsonSgit/Remindr/assets/92652800/b55dd172-3a8a-41f1-8ba1-6bbaf0c80778)

![loadCSV](https://github.com/carsonSgit/Remindr/assets/92652800/4cdef53d-fcb4-4dab-9bab-8d4f0ecdae75)

![newTasks](https://github.com/carsonSgit/Remindr/assets/92652800/ef87e7c8-c706-45ae-9de5-6447cf7969a1)

## Due Today Report

> 📅 Click on the Due Today button to display a report of tasks due today.

![u1iziqK](https://github.com/carsonSgit/Remindr/assets/92652800/0a1edf6c-448c-44fc-ad4b-bf7be831ba29)

### If there are tasks due today, we display this report

![dueToday](https://github.com/carsonSgit/Remindr/assets/92652800/048e8965-1d03-4d4b-bbe1-4da13151e5be)

### If there are none, we see this

![nothingDueToday](https://github.com/carsonSgit/Remindr/assets/92652800/71b27fe3-baea-4e65-a72f-9ad4ac41568f)

## Overdue Report

> ⏰ Click on the Overdue button to display a report of tasks that have passed the due date

![9zOMwHY](https://github.com/carsonSgit/Remindr/assets/92652800/139c37c7-2657-418c-b753-a5a9c0018008)

### If there are tasks that are Overdue, we display this report

![overDue](https://github.com/carsonSgit/Remindr/assets/92652800/7452012d-ed2c-4d33-852d-4fc088c36def)

### If we have no overdue tasks, we see this

![nothingOverDue](https://github.com/carsonSgit/Remindr/assets/92652800/7d4b1abf-cd69-4e37-9d2c-e894cbcd8b70)
