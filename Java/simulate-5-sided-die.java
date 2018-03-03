public class Randos {
    private Random rand = new Random();

    // Efficiency: O(infinity, potentially...if we have really, really....really bad luck)
    public int rand5() {
        int num = rand7();
        while(num > 5) {
            num = rand7();
        }
        return num;
    }

    private int rand7() {
        return this.rand.nextInt(8);
    }
}