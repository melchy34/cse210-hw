import pickle

# Base class for all goals
class Goal:
    def __init__(self, name, score):
        self.name = name
        self.score = score
        self._completed = False

    def record_event(self):
        raise NotImplementedError("Subclasses should implement this method.")

    def get_score(self):
        return self.score

    def is_completed(self):
        return self._completed

    def mark_complete(self):
        self._completed = True

# Simple goal that is completed once
class SimpleGoal(Goal):
    def __init__(self, name, score):
        super().__init__(name, score)

    def record_event(self):
        if not self.is_completed():
            self.mark_complete()
            return self.score
        return 0  # No points if already completed

# Eternal goal that gets points each time it is recorded
class EternalGoal(Goal):
    def __init__(self, name, score_per_record):
        super().__init__(name, 0)
        self.score_per_record = score_per_record

    def record_event(self):
        return self.score_per_record

# Checklist goal that must be completed a certain number of times
class ChecklistGoal(Goal):
    def __init__(self, name, score_per_record, target):
        super().__init__(name, score_per_record * target)
        self.score_per_record = score_per_record
        self.target = target
        self._progress = 0

    def record_event(self):
        if self._progress < self.target:
            self._progress += 1
            return self.score_per_record
        elif self._progress == self.target:
            self._progress += 1  # This prevents re-recording
            return self.score_per_record + 500  # Bonus points
        return 0  # No points if already completed

    def progress(self):
        return self._progress

# User class to manage goals and score
class User:
    def __init__(self):
        self.goals = []
        self.total_score = 0

    def create_goal(self, goal_type, name, score, *args):
        if goal_type == 'simple':
            goal = SimpleGoal(name, score)
        elif goal_type == 'eternal':
            goal = EternalGoal(name, score)
        elif goal_type == 'checklist':
            target = args[0]
            goal = ChecklistGoal(name, score, target)
        else:
            raise ValueError("Unknown goal type")
        
        self.goals.append(goal)

    def record_event(self, goal_name):
        for goal in self.goals:
            if goal.name == goal_name and not goal.is_completed():
                points = goal.record_event()
                self.total_score += points
                return points
        return 0  # Goal not found or already completed

    def show_goals(self):
        for goal in self.goals:
            if isinstance(goal, ChecklistGoal):
                print(f"[{'X' if goal.is_completed() else ' '}] {goal.name} - Completed {goal.progress()}/{goal.target}")
            else:
                print(f"[{'X' if goal.is_completed() else ' '}] {goal.name}")

    def save_data(self, filename="user_data.pkl"):
        with open(filename, 'wb') as file:
            pickle.dump(self, file)

    @staticmethod
    def load_data(filename="user_data.pkl"):
        try:
            with open(filename, 'rb') as file:
                return pickle.load(file)
        except FileNotFoundError:
            return User()

    def get_total_score(self):
        return self.total_score

# Example usage
user = User()

# Create different types of goals
user.create_goal('simple', 'Run a Marathon', 1000)
user.create_goal('eternal', 'Read Scriptures', 100)
user.create_goal('checklist', 'Attend the Temple', 50, 10)

# Record events
user.record_event('Run a Marathon')
user.record_event('Read Scriptures')
user.record_event('Attend the Temple')

# Display current goals and total score
user.show_goals()
print(f"Total Score: {user.get_total_score()}")

# Save user data
user.save_data()

# Load user data
loaded_user = User.load_data()
print(f"Loaded Total Score: {loaded_user.get_total_score()}")
