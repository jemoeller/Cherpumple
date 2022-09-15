using System.Globalization;
using Cherpumple.Application.Common.Interfaces;
using Cherpumple.Application.TodoLists.Queries.ExportTodos;
using Cherpumple.Infrastructure.Files.Maps;
using CsvHelper;

namespace Cherpumple.Infrastructure.Files;

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
