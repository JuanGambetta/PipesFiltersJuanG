using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterCognitiveAPI : IFilterConditional
    {
        public bool Filter(IPicture image)
        {
            CognitiveFace cog = new CognitiveFace(false);
            cog.Recognize(@"luke.jpg");
            return cog.FaceFound;  
        }
    }
}