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