

namespace Homework3
{
    public class CSE : Student
    {
        private double computerNetworkGrade;
        private double dataStructurGradee;
        private double testingGrade;

        public double ComputerNetworkGrade
        {
            get { return computerNetworkGrade; }
            set { computerNetworkGrade = value; }
        }
        public double DataStructureGrade
        {
            get { return dataStructurGradee; }
        }
        public double TestingGrade
        {
            get { return testingGrade; }
        }

        public override double AverageGrade
        {
            get
            {
                return averageGrade;
            }
            set
            {
                averageGrade = (computerNetworkGrade + dataStructurGradee + testingGrade) / 3;
            }
        }

        public CSE(string studentName, int id, double computerNetworkGrade, double dataStructure, double testing) :base(studentName, id)
        {
            this.computerNetworkGrade = computerNetworkGrade;
            this.dataStructurGradee = dataStructure;
            this.testingGrade = testing;
            this.AverageGrade = (computerNetworkGrade + dataStructure + testing) / 3;
        }


    }
}
