// Time: O(1) for all methods, Space: O(1)
public class TempTracker
{
    private int? min;
    private int? max;
    private double? mean;
    private int? sum;
    private int? size;
    private int[] occurences = new int[1000]; // array holding up to 1000 degree F temps
    private int? maxOccurences;
    private int? mode;


    // O(1)
    public void insert(int temp)
    {

        // track min:
        if (this.min == null || temp < this.min)
        {
            this.min = temp;
        }

        // track max:
        if (this.max == null || temp > this.max)
        {
            this.max = temp;
        }

        // track size:
        this.size++;

        // track sum:
        this.sum += temp;

        // track mean:
        this.mean = (double)this.sum / this.size;

        // track mode:
        this.occurences[temp]++;
        if (this.occurences[temp] > this.maxOccurences)
        {
            this.mode = temp;
            this.maxOccurences = this.occurences[temp];
        }
    }

    // O(1)
    public int? getMax()
    {
        return this.max;
    }

    // O(1)
    public int? getMin()
    {
        return this.min;
    }

    // O(1)
    public double? getMean()
    {
        return (double)this.sum / this.size;
    }

    // O(1)
    public int? getMode()
    {
        return this.mode;
    }
}