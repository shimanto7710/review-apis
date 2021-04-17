using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using review_apis.Models;
using review_apis.ProfileData;

using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using review_apis.Repo.Interface;
using review_apis.Repo.RealRepo;

namespace review_apis
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContextPool<DbReferenceContext>(option => option.UseSqlServer(Configuration.GetConnectionString("ProfileContextConnection")));
            services.AddScoped<ProfileInterface, SqlProfileData>();
            services.AddScoped<UserInterface, SqlUserData>();
            services.AddScoped<BadgeInterface, SqlBadge>();
            services.AddScoped<ReviewInterface, SqlReview>();
            services.AddScoped<FoodItemInterface, SqlFoodItem>();
            services.AddScoped<ReviewedFoodItemInterface, SqlReviewedFoodItem>();
            services.AddScoped<RestaurantInterface, SqlRestaurant>();
            services.AddScoped<ReviewedRestaurantInterface, SqlReviewedRestaurant>();
            services.AddScoped<ImageInterface, SqlImage>();
            services.AddScoped<TagInterface, SqlTag>();
            services.AddScoped<CommentInterface, SqlComment>();
            services.AddScoped<ReactionInterface, SqlReaction>();
            services.AddScoped<CommentReactionInterface, SqlCommentReaction>();
            services.AddScoped<ReplyInterface, SqlReply>();
            services.AddScoped<ReplyReactionInterface, SqlReplyReaction>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["Jwt:Audience"],
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });
         }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
