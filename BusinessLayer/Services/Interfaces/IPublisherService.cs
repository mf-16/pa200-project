using BusinessLayer.DTOs.Publisher;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces;

public interface IPublisherService
{
    Task<IEnumerable<ResponsePublisherDto>> GetAllPublishersAsync();
    Task<ResponsePublisherDto> GetPublisherByIdAsync(int id);
    Task<ResponsePublisherDto> AddPublisherAsync(AddPublisherDto addPublisherDto);
    Task<ResponsePublisherDto> UpdatePublisherAsync(int id, AddPublisherDto updatePublisherDto);
    Task DeletePublisherAsync(int id);
}
