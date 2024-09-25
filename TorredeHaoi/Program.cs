private const int DISC_COUNT = 10;
private const int DELAY_MS = 250;
private static int _columnSize = 30;

static void Main {Strig[] args}
{
    _columnSize = Math.Max (6, GetDiscWWidth (DISC_COUNT) +2;
    TorredeHaoi algorithm = new TorredeHaoi (DISC_COUNT);
    algorithm.JogadaCompleta += Algorithm_Visualize;
    Algorithm_Visualize(algorithm, EventArgs.Empty);
    algorithm.Start();
}