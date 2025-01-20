public class Job {
    private String title;
    private String company;
    private int yearsWorked;

    // Constructor
    public Job(String title, String company, int yearsWorked) {
        this.title = title;
        this.company = company;
        this.yearsWorked = yearsWorked;
    }

    // Getter for title
    public String getTitle() {
        return title;
    }

    // Setter for title
    public void setTitle(String title) {
        this.title = title;
    }

    // Getter for company
    public String getCompany() {
        return company;
    }

    // Setter for company
    public void setCompany(String company) {
        this.company = company;
    }

    // Getter for yearsWorked
    public int getYearsWorked() {
        return yearsWorked;
    }

    // Setter for yearsWorked
    public void setYearsWorked(int yearsWorked) {
        this.yearsWorked = yearsWorked;
    }

    // Method to display job details
    public String displayJob() {
        return title + " at " + company + " for " + yearsWorked + " years.";
    }
}
