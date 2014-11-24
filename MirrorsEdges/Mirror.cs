using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MirrorsEdges
{
    class Mirror
    {
        /// <summary>
        /// Number of points in mirror
        /// </summary>
        private List<double> points;
        /// <summary>
        /// Indicates how far from 0 can mirror point get while it's generated
        /// </summary>
        private const double pointSpan = 30;

        /// <summary>
        /// Default constructor. Makes mirror with no points
        /// </summary>
        public Mirror()
        {
            points = new List<double>();
        }

        /// <summary>
        /// Makes random mirror using random seed (time based)
        /// </summary>
        /// <param name="pointCount">How much poinst mirror should have</param>
        public Mirror(int pointCount)
        {
            Random r = new Random(DateTime.Now.Millisecond);        //some random seed

            points = new List<double>(pointCount);

            for (int i = 0; i < pointCount; i++)
            {
                points[i] = r.NextDouble() * pointSpan;
            }
        }

        /// <summary>
        /// Makes random mirror usin specifed seed
        /// </summary>
        /// <param name="pointCount">How much poinst mirror should have</param>
        /// <param name="seed">Seed for random generation</param>
        public Mirror(int pointCount, int seed)
        {
            Random r = new Random(seed);

            points = new List<double>(pointCount);

            for (int i = 0; i < pointCount; i++)
            {
                points[i] = r.NextDouble() * pointSpan;
            }
        }

    }
}
