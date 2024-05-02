using KeyOneTest.Models;
using KeyOneTest.Repositories;

namespace KeyOneTest.Services
{
    /// <summary>
    /// Represents a service for processing objects.
    /// </summary>
    public class ObjetoService : IObjetoService
    {
        /// <summary>
        /// Method to process data and generate response objects.
        /// </summary>
        /// <returns>the processed data</returns>
        public List<ResponseObject> ProcessData()
        {
            // Initialize a list to store processed data.
            List<ResponseObject> processData = [];

            // Retrieve objects from the repository.
            List<Objeto> Objects = ObjectRepository.Objects;

            // Group objects by category, calculate total value, average value, and latest date for each category.
            var categorySum = Objects.GroupBy(obj => obj.Category)
                                 .Select(group => new
                                 {
                                     Category = group.Key,
                                     TotalValue = group.Sum(obj => obj.Value),
                                     AverageValue = group.Average(obj => obj.Value),
                                     LatestDate = group.OrderByDescending(obj => obj.Date).FirstOrDefault()?.Date
                                 }).OrderByDescending(item => item.TotalValue);

            // Iterate through the grouped data and create response objects.
            foreach (var item in categorySum)
            {
                ResponseObject responseObject = new()
                {
                    Category = item.Category,
                    ValueSum = item.TotalValue,
                    LastDate = item.LatestDate,
                    ValueAvg = (int)item.AverageValue
                };

                // Add response object to the list.
                processData.Add(responseObject);
            }

            // Return the processed data.
            return processData;
        }
    }
}
