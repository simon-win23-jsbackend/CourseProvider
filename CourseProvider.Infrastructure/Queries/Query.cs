using CourseProvider.Infrastructure.Models;
using CourseProvider.Infrastructure.Services;

namespace CourseProvider.Infrastructure.Queries;

public class Query(ICourseSerivce courseSerivce)
{
    private readonly ICourseSerivce _courseSerivce = courseSerivce;

    [GraphQLName("getCourses")]
    public async Task<IEnumerable<Course>> GetCoursesAsync()
    {
        return await _courseSerivce.GetCoursesAsync();
    }
    [GraphQLName("getCourseById")]
    public async Task<Course> GetCourseByIdAsync(string id)
    {
        return await _courseSerivce.GetCourseByIdAsync(id);

    }
}
