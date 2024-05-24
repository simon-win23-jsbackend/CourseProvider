
using CourseProvider.Infrastructure.Models;
using CourseProvider.Infrastructure.Services;

namespace CourseProvider.Infrastructure.GraphQL.Mutations;

public class CourseMutation(ICourseSerivce courseSerivce)
{
    private readonly ICourseSerivce _courseSerivce = courseSerivce;

    [GraphQLName("createCourse")]
    public async Task<Course> CreateCourseAsync (CourseCreateRequest input)
    {
        return await _courseSerivce.CreateCourseAsync (input);
    }
    [GraphQLName("updateCourse")]
    public async Task<Course> UpdateCourseAsync (CourseUpdateRequest input)
    {
        return await _courseSerivce.UpdateCourseAsync (input);
    }
    [GraphQLName("deleteCourse")]
    public async Task<bool> DeleteCourseAsync(string id)
    {
        return await _courseSerivce.DeleteCourseAsync (id);
    }
}
