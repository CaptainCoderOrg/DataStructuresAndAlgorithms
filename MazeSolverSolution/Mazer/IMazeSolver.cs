namespace Mazer;

public interface IMazeSolver
{
    public static IMazeSolver Default { get; set; } = new DFSMazeSolver();
    // public List<Position> Solve(IMaze toSolve);
    public bool TrySolve(IMaze toSolve, out List<Position> solution);
}

