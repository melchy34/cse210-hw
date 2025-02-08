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
