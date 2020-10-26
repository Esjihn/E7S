namespace E7S.ViewInterfaces
{
    public interface IArrowUserControl
    {
        public string DebuffDirection { get; }
        public string DirectionWanted { get; }
        public void DirectionToFace(string result);
    }
}