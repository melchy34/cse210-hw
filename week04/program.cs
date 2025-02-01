class Comment:
    def __init__(self, commenter_name, text):
        self.commenter_name = commenter_name
        self.text = text

    def __str__(self):
        return f"{self.commenter_name}: {self.text}"


class Video:
    def __init__(self, title, author, length):
        self.title = title
        self.author = author
        self.length = length
        self.comments = []

    def add_comment(self, comment):
        self.comments.append(comment)

    def get_number_of_comments(self):
        return len(self.comments)

    def __str__(self):
        return f"Title: {self.title}\nAuthor: {self.author}\nLength: {self.length} seconds\nNumber of comments: {self.get_number_of_comments()}"


# Create some videos
video1 = Video("Python Tutorial for Beginners", "John Doe", 300)
video2 = Video("Advanced Python Tips", "Jane Smith", 450)
video3 = Video("How to Build a Python App", "Alice Brown", 600)

# Add comments to the videos
video1.add_comment(Comment("Mike", "Great lesson!"));
video1.add_comment(Comment("Sarah", "Very helpful, thanks!"))
video1.add_comment(Comment("Tom", "I learned a lot."))

video2.add_comment(Comment("Lucas", "This is super advanced!"))
video2.add_comment(Comment("Olivia", "Great tips for experienced developers."))

video3.add_comment(Comment("Jake", "Can't wait to try this out."))
video3.add_comment(Comment("Emma", "Thanks for the step-by-step guide."))
video3.add_comment(Comment("Liam", "Amazing content, very thorough."))

# List of videos
videos = [video1, video2, video3]

# Display details for each video and its comments
for video in videos:
    print(video)
    for comment in video.comments:
        print(comment)
    print("\n" + "-"*40 + "\n")