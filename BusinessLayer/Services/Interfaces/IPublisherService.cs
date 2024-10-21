using BusinessLayer.DTOs.Publisher;

namespace BusinessLayer.Services;
public interface IPublisherService
{
    Task<IEnumerable<ResponsePublisherDto>> GetAllPublishersAsync();
    Task<ResponsePublisherDto> GetPublisherByIdAsync(int id);
    Task<ResponsePublisherDto> AddPublisherAsync(AddPublisherDto addPublisherDto);
    Task<ResponsePublisherDto> UpdatePublisherAsync(int id, AddPublisherDto updatePublisherDto);
    Task DeletePublisherAsync(int id);
}
