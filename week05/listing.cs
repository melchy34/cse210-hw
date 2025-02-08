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