

namespace Homework3
{
    class ECE : Student
    {

        private double electronicCircuitsGrade;
        private double circuitAnalysisGrade;
        private double analogCommunicationGrade;

        public double ElectronicCircuitsGrade
        {
            get { return electronicCircuitsGrade; }
            set { electronicCircuitsGrade = value; }
        }
        public double CircuitAnalysisGrade
        {
            get { return circuitAnalysisGrade; }
        }
        public double AnalogCommunicationGrade
        {
            get { return analogCommunicationGrade; }
        }

        public override double AverageGrade
        {
            get
            {
                return averageGrade;
            }
            set
            {
                averageGrade = (electronicCircuitsGrade + circuitAnalysisGrade + analogCommunicationGrade) / 3;
            }
        }

        public ECE(string studentName, int id, double electronicCircuits, double circuitAnalysis, double analogCommunication):base(studentName, id)
        {
            this.electronicCircuitsGrade = electronicCircuits;
            this.circuitAnalysisGrade = circuitAnalysis;
            this.analogCommunicationGrade = analogCommunication;
            this.AverageGrade = (electronicCircuits + circuitAnalysis + analogCommunication) / 3;
        }

    }
}
