using DotNetEnv;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFitAdmin
{
    public class FireBaseService
    {
        private FirebaseClient client;
        private string firebaseUrl;

        private static readonly object _lock = new object();
        private static FireBaseService _instance;

        private const string POSTS_DB_NAME = "post";
        private const string ACTIVITIES_DB_NAME = "activities";

        private FireBaseService()
        {
            Env.Load();
            firebaseUrl = Env.GetString("FIREBASE_URL");
            client = new FirebaseClient(firebaseUrl);
        }

        public static FireBaseService Instance()
        {
            lock(_lock)
            {
                if(_instance == null)
                    _instance = new FireBaseService();
                return _instance;
            }
        }

        public async Task<List<PostItem>> GetAllPosts()
        {
            var posts = await client
                .Child(POSTS_DB_NAME)
                .OnceAsync<PostItem>();

            return posts.Select(post => post.Object).ToList();
        }

        public async Task post(PostItem post)
        {
           await client.Child(POSTS_DB_NAME).PostAsync(post);
        }

        public async Task deletePost(string postTitle)
        {
            var posts = await client.Child(POSTS_DB_NAME).OnceAsync<PostItem>();

            var postItem = posts.FirstOrDefault(post => post.Object.Title == postTitle);

            await client.Child(POSTS_DB_NAME).Child(postItem.Key).DeleteAsync();
        }

        public async Task<List<ActivityItem>> GetAllActivities()
        {
            var activities = await client
                .Child(ACTIVITIES_DB_NAME)
                .OnceAsync<ActivityItem>();

            return activities.Select(activity => activity.Object).ToList();
        }

        public async Task PostActivity(ActivityItem activity)
        {
            await client.Child(ACTIVITIES_DB_NAME).PostAsync(activity);
        }

        public async Task DeleteActivity(string activityTitle)
        {
            var activities = await client.Child(ACTIVITIES_DB_NAME).OnceAsync<ActivityItem>();

            var activityItem = activities.FirstOrDefault(activity => activity.Object.Name == activityTitle);

            if (activityItem != null)
            {
                await client.Child(ACTIVITIES_DB_NAME).Child(activityItem.Key).DeleteAsync();
            }
        }
    }
}
