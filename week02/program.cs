import random
import datetime

class Entry:
    def _init_(self, prompt, response, date):
        self.prompt = prompt
        self.response = response
        self.date = date

class Journal:
    def _init_(self):
        self.entries = []

    def add_entry(self, prompt, response):
        date = datetime.datetime.now().strftime("%Y-%m-%d")
        entry = Entry(prompt, response, date)
        self.entries.append(entry)

    def display_entries(self):
        for entry in self.entries:
            print(f"Date: {entry.date}")
            print(f"Prompt: {entry.prompt}")
            print(f"Response: {entry.response}")
            print()

    def save_journal(self, filename):
        with open(filename, 'w') as file:
            for entry in self.entries:
                file.write(f"Date: {entry.date}\n")
                file.write(f"Prompt: {entry.prompt}\n")
                file.write(f"Response: {entry.response}\n\n")

    def load_journal(self, filename):
        self.entries = []
        with open(filename, 'r') as file:
            lines = file.readlines()
            for i in range(0, len(lines), 4):
                date = lines[i].strip().split(': ')[1]
                prompt = lines[i + 1].strip().split(': ')[1]
                response = lines[i + 2].strip().split(': ')[1]
                entry = Entry(prompt, response, date)
                self.entries.append(entry)

class Program:
    def _init_(self):
        self.journal = Journal()
        self.prompts = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        ]

    def run(self):
        while True:
            self.display_menu()
            choice = input("Enter your choice: ")
            if choice == "1":
                self.write_new_entry()
            elif choice == "2":
                self.display_journal()
            elif choice == "3":
                self.save_journal()
            elif choice == "4":
                self.load_journal()
            elif choice == "5":
                print("Exiting program...")
                break
            else:
                print("Invalid choice. Please try again.")

    def display_menu(self):
        print("----- Menu -----")
        print("1. Write a new entry")
        print("2. Display the journal")
        print("3. Save the journal to a file")
        print("4. Load the journal from a file")
        print("5. Quit")

    def write_new_entry(self):
        prompt = random.choice(self.prompts)
        response = input(f"{prompt}\n")
        self.journal.add_entry(prompt, response)

    def display_journal(self):
        if len(self.journal.entries) == 0:
            print("No entries found.")
        else:
            self.journal.display_entries()

    def save_journal(self):
        filename = input("Enter the filename to save the journal: ")
        self.journal.save_journal(filename)
        print("Journal saved successfully.")

    def load_journal(self):
        filename = input("Enter the filename to load the journal: ")
        self.journal.load_journal(filename)
        print("Journal loaded successfully.")

# Run the program
program = Program()
program.run()
import randon import datetime
 
class Entry:
 
def init(self, prompt, response, date):
 
self.prompt prompt
 
self.response = response self.date date
 
class Journal:
 
def init_(self): self,entries = []
 
def add entry(self, prompt, response):
 
date = datetime.datetime.now().trftime("--"} entry Entry(prompt, response, date)
 
self.entries.append(entry)
 
def display entries(self):
 
for entry in self.entries: print("Date: fentry.date}")
 
print("Prompt: fentry.prompt)")
 
print("Response: fentry.response)")
 
print()
 
def
 
save journal (self, filename):
 
with open(filename, 'w') as file:
 
for entry in self.entries:
 
file.write("Date: fentry.date}\n") file.write("Prompt: (entry.prompt}\n")
 
file.write("Response: fentry.response}\n\n")
 
def Load journal (self,
 
filename):
 
self.entries = []
 
with open(filename, 'r') as file:
 
Lines = file.readlines()
 
for i in range(0, Len(Lines), ):
 
date = lines[i].strip).split(': [] prompt = Lines [11].strio).split(': [] response = Linesli + 21.strip0).split(":")[1]
 
entry Entry (prompt, response, date)
 
self.entries.append(entry)
 
class Program:
 
def _init_(self):
 
self.journal Journal() self.prompts = [
 
"Who was the most interesting person I interacted with today?",
 
"What was the best part of my day?",
 
"How did I see the hand of the Lord in my life today?",
 
"What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"
}
def run(self):
 
while True:
 
self.display_menu()
 
choice = input("Enter your choice: ") if choice = "1":
 
self.write new entry()
 
elif choice = "2":
 
self.display_journal() elif choice = "3":
 
self.save_journal()
 
elif choice = "4":
 
self.load journal()
 
elif choice = "5":
 
print("Exiting program...")
 
break else:
 
print("Invalid choice. Please try again.")
 
def display menu(self):
print("-----Menu------")
 
print("1. Write a new entry")
 
print("2. Display the Journal")
 
print("3. Save the journal to a file") print("4. Load the journal from a file")
 
print("5. Quit")
 
def write new entry(self):
 
prompt = random.choice(self.prompts) response = input("{prompt}\n")
 
self.journal.ado entry (prompt, response)
 
def display_journal (self):
 
if len(self.journal.entries) 0:
 
print("No entries found.")
 
else: self.journal.display_entries()
 
def save journal (self): Filename = input("Enter the filename
 
to save the journal: ")
 
self.journal.save_journal (filename)
 
print("Journal saved successfully.")
 
def Load journal (self):
 
Filename = input("Enter the filename to load the journal: ") self.journal.Load_journal (filename)
 
print("Journal Loaded successfully.")
 
Avn the program
 
program = Program() program.run()
import randon import datetime
 
class Entry:
 
def init(self, prompt, response, date):
 
self.prompt prompt
 
self.response = response self.date date
 
class Journal:
 
def init_(self): self,entries = []
 
def add entry(self, prompt, response):
 
date = datetime.datetime.now().trftime("--"} entry Entry(prompt, response, date)
 
self.entries.append(entry)
 
def display entries(self):
 
for entry in self.entries: print("Date: fentry.date}")
 
print("Prompt: fentry.prompt)")
 
print("Response: fentry.response)")
 
print()
 
def
 
save journal (self, filename):
 
with open(filename, 'w') as file:
 
for entry in self.entries:
 
file.write("Date: fentry.date}\n") file.write("Prompt: (entry.prompt}\n")
 
file.write("Response: fentry.response}\n\n")
 
def Load journal (self,
 
filename):
 
self.entries = []
 
with open(filename, 'r') as file:
 
Lines = file.readlines()
 
for i in range(0, Len(Lines),):
 
date = lines[i].strip).split(': [] prompt = Lines [11].strio).split(': [] response = Linesli + 21.strip0).split(":")[1]
 
entry Entry (prompt, response, date)
 
self.entries.append(entry)
 
class Program:
 
def _init_(self):
 
self.journal Journal() self.prompts = [
 
"Who was the most interesting person I interacted with today?",
 
"What was the best part of my day?",
 
"How did I see the hand of the Lord in my life today?",
 
"What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" 
}
def run(self):
 
while True:
 
self.display_menu()
 
choice = input("Enter your choice: ") if choice = "1":
 
self.write new entry()
 
elif choice = "2":
 
self.display_journal() elif choice = "3":
 
self.save_journal()
 
elif choice = "4":
 
self.load journal()
 
elif choice = "5":
 
print("Exiting program...")
 
break else:
 
print("Invalid choice. Please try again.")
 
def display menu(self): print(" Menu
 
print("1. Write a new entry")
 
print("2. Display the Journal")
 
print("3. Save the journal to a file") print("4. Load the journal from a file")
 
print("5. Quit")
 
def write new entry(self):
 
prompt = random.choice(self.prompts) response = input("{prompt}\n")
 
self.journal.ado entry (prompt, response)
 
def display_journal (self):
 
if len(self.journal.entries) 0:
 
print("No entries found.")
 
else: self.journal.display_entries()
 
def save journal (self): Filename = input("Enter the filename
 
to save the journal: ")
 
self.journal.save_journal (filename)
 
print("Journal saved successfully.")
 
def Load journal (self):
 
Filename = input("Enter the filename to load the journal: ") self.journal.Load_journal (filename)
 
print("Journal Loaded successfully.")
 
Avn the program
 
program = Program() program.run()