namespace TodoList.Mappers.ApiProfile
{
    using AutoMapper;

    using TodoList.Data.Entities.Task;
    using TodoList.Services.Models.Task;

    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            #region Entities to Models

            CreateMap<TaskEntity, TaskModel>();

            #endregion

            #region Models to Entities

            CreateMap<TaskModel, TaskEntity>();

            #endregion
        }
    }
}
