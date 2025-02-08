import time
import random
import threading

# Base class
class Activity:
    def __init__(self, name, description):
        self.name = name
        self.description = description
        self.duration = 0

    def set_duration(self):
        self.duration = int(input(f"Enter the duration (in seconds) for {self.name}: "))
        self.show_start_message()

    def show_start_message(self):
        print(f"Starting the {self.name} activity.")
        print(self.description)
        print("Get ready to begin...")
        self.pause_for(3)  # Pause for 3 seconds

    def pause_for(self, seconds):
        for i in range(seconds):
            print(".", end="", flush=True)
            time.sleep(1)
        print()  # For newline

    def show_end_message(self):
        print("Good job!")
        print(f"You have completed the {self.name} activity for {self.duration} seconds.")
        self.pause_for(3)  # Pause for 3 seconds


# Breathing Activity Class
class BreathingActivity(Activity):
    def __init__(self):
        super().__init__("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")

    def start(self):
        self.set_duration()
        print("Let's begin the Breathing Activity!")
        start_time = time.time()
        while time.time() - start_time < self.duration:
            print("Breathe in...")
            self.pause_for(5)  # Pause for 5 seconds
            print("Breathe out...")
            self.pause_for(5)  # Pause for 5 seconds
        self.show_end_message()

# Reflection Activity Class
class ReflectionActivity(Activity):
    def __init__(self):
        super().__init__("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")

    def start(self):
        self.set_duration()
        print("Let's begin the Reflection Activity!")
        prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need."
        ]
        questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?"
        ]
        random_prompt = random.choice(prompts)
        print(random_prompt)
        self.pause_for(2)  # Pause for 2 seconds
        
        start_time = time.time()
        while time.time() - start_time < self.duration:
            random_question = random.choice(questions)
            print(random_question)
            self.pause_for(5)  # Pause for 5 seconds
        self.show_end_message()

# Listing Activity Class

class ListingActivity(Activity):
    def __init__(self):
        super().__init__("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")

    def start(self):
        self.set_duration()
        print("Let's begin the Listing Activity!")
        prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?"
        ]
        random_prompt = random.choice(prompts)
        print(random_prompt)
        self.pause_for(2)  # Pause for 2 seconds

        print("Start listing! Press Enter after each item. When you're done, press Enter again.")
        items = []
        start_time = time.time()
        while time.time() - start_time < self.duration:
            item = input("> ")
            if item:
                items.append(item)
        print(f"You listed {len(items)} items.")
        self.show_end_message()


# Main Program
def main_menu():
    activities = {
        1: BreathingActivity(),
        2: ReflectionActivity(),
        3: ListingActivity()
    }
while True:
        print("\nChoose an activity:")
        print("1. Breathing Activity")
        print("2. Reflection Activity")
        print("3. Listing Activity")
        print("4. Exit")

        choice = int(input("Enter the number of the activity you want to try: "))
        if choice == 4:
            print("Goodbye!")
            break
        elif choice in activities:
            activity = activities[choice]
            activity.start()
        else:
            print("Invalid choice, please try again.")


# Run the program
if __name__ == "__main__":
    main_menu()