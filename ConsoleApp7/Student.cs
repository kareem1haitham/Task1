internal class Student
{
    private string v1;
    private string v2;
    private object value;

    public Student()
    {
    }

    public Student(string v1, string v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public Student(string v1, string v2, object value)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.value = value;
    }

    public Student(string v1, string v2, object value, string v) : this(v1, v2, value)
    {
    }

    public Student(string v1, string v2, object value, string v, string v3, string v4, string v5) : this(v1, v2, value, v)
    {
    }
}