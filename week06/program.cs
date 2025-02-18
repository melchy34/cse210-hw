import pickle

# Base Class: Goal
class Goal:
    def __init__(self, name, description, score_value):
        self._name = name
        self._description = description
        self._score_value = score_value
        self._completed = False
        self._score = 0
    
    def record_event(self):
        """Record an event for the goal and update the score."""
        pass
    
    def display(self):
        """Display the goal details."""
        pass
    
    @property
    def score(self):
        return self._score

    @property
    def name(self):
        return self._name
    
    @property
    def description(self):
        return self._description

# Derived Class: SimpleGoal
class SimpleGoal(Goal):
    def __init__(self, name, description, score_value):
        super().__init__(name, description, score_value)
    
    def record_event(self):
        """Mark the goal as completed and add the score."""
        if not self._completed:
            self._completed = True
            self._score += self._score_value
    
    def display(self):
        status = "[X]" if self._completed else "[ ]"
        return f"{status} {self._name}: {self._description} | Score: {self._score}"

# Derived Class: EternalGoal
class EternalGoal(Goal):
    def __init__(self, name, description, score_value):
        super().__init__(name, description, score_value)
    
    def record_event(self):
        """Add points each time the goal is recorded."""
        self._score += self._score_value
    
    def display(self):
        return f"[ ] {self._name}: {self._description} | Total Points: {self._score}"

# Derived Class: ChecklistGoal
class ChecklistGoal(Goal):
    def __init__(self, name, description, score_value, target_count):
        super().__init__(name, description, score_value)
        self._target_count = target_count
        self._current_count = 0
        self._bonus_points = 500  # Bonus on completion

    def record_event(self):
        """Increment the count and update the score."""
        if self._current_count < self._target_count:
            self._current_count += 1
            self._score += self._score_value
            if self._current_count == self._target_count:
                self._score += self._bonus_points

    def display(self):
        return f"[ ] {self._name}: {self._description} | Completed {self._current_count}/{self._target_count} times | Score: {self._score}"

# Goal Manager to handle user goals
class GoalManager:
    def __init__(self):
        self._goals = []
        self._total_score = 0

    def add_goal(self, goal):
        """Add a goal to the list."""
        self._goals.append(goal)
    
    def record_goal_event(self, goal_name):
        """Record an event for a specific goal."""
        for goal in self._goals:
            if goal.name == goal_name:
                goal.record_event()
                self._total_score += goal.score
                break
    
    def display_goals(self):
        """Display all goals and their current status."""
        for goal in self._goals:
            print(goal.display())
    
    def display_score(self):
        """Display the total score of the user."""
        print(f"Total Score: {self._total_score}")

    def save_goals(self, filename="goals.pkl"):
        """Save goals and score to a file."""
        with open(filename, "wb") as file:
            pickle.dump((self._goals, self._total_score), file)

    def load_goals(self, filename="goals.pkl"):
        """Load goals and score from a file."""
        try:
            with open(filename, "rb") as file:
                self._goals, self._total_score = pickle.load(file)
        except FileNotFoundError:
            print("No saved goals found.")
