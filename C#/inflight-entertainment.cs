// Time: O(n), Space:O(n)
public bool areTwoMovies(int flightLength, int[] movieLengths)
{
    HashSet<int> movieTimes = new HashSet<int>();
    foreach (int movieLength in movieLengths)
    {
        int lengthDiff = flightLength - movieLength;
        if (movieTimes.Contains(lengthDiff))
        {
            return true;
        }
        movieTimes.Add(movieLength);
    }
    return false;
}