
public interface IPath
{
    public float Length {get;}
    
    public IPathCursor CreateCursor();
}
