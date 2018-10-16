namespace Lab05_OOP_Zoo.Classes
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class Eatable
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get => m_Name;
            set => m_Name = value;
        }
        private string m_Name;


        /// <summary>
        /// 
        /// </summary>
        public int Weight
        {
            get => m_weight;
            set => m_weight = value;
        }
        private int m_weight;


        /// <summary>
        /// 
        /// </summary>
        private long UID;

        public override string ToString()
        {
            return this.Name;
        }
    }
}
