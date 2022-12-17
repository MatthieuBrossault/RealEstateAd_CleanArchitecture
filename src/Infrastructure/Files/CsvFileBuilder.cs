using System.Globalization;
using RealEstateAd_CleanArchitecture.Application.Common.Interfaces;
using RealEstateAd_CleanArchitecture.Application.TodoLists.Queries.ExportTodos;
using RealEstateAd_CleanArchitecture.Infrastructure.Files.Maps;
using CsvHelper;

namespace RealEstateAd_CleanArchitecture.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
