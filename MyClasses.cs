using System;
using System.Collections.Generic;

namespace BakeryShoppingCart.Models
{
    public class ShoppingCart
    {
        private List<User> userList = new List<User>();
        private List<Comment> commentReviewList = new List<Comment>();

        public ShoppingCart()
        {
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. Create a User");
            Console.WriteLine("2. Create a Comment");
            Console.WriteLine("3. Print the list of Users");
            Console.WriteLine("4. Print the list of Comments");
            Console.WriteLine("5. Exit");
        }

        public string CaptureResponse()
        {
            string response = Console.ReadLine();

            return response;
        }

        public void CreateUser()
        {
            User myUser = new User();
            myUser.Email = "myemail@somewhere.com";
            myUser.Password = "Password";
            myUser.UserId = 1;
            myUser.UserName = "Huncho";

            userList.Add(myUser);

            Console.WriteLine("");
            Console.WriteLine("You have created a User");
            Console.WriteLine("");
        }

        public void CreateCakeReview()
        {
            Comment review = new Comment();
            review.Comment = 1;
            review.Comment = 1;
            review.Review = "young jit";

            commentReviewList.Add(review);

            Console.WriteLine("");
            Console.WriteLine("You have added a review for your Comments");
            Console.WriteLine("");
        }

        public void ShowAllExistingUsers()
        {
            int userCount = 1;

            string format = "User {0}: Has the following data.- User Name[{1}], Password[{2}], " +
                            "UserId[{3}], Email[{4}]";

            Console.WriteLine("");
            foreach (var user in userList)
            {
                Console.WriteLine(String.Format(format, userCount, user.UserName, user.Password,
                                                user.UserId, user.Password));

                userCount++;
            }
            Console.WriteLine("");
        }

        public void ShowAllExistingCommentReviews()
        {
            int reviewCount = 1;

            string format = "Cake Review {0}: Has the following data.- Review belings to cake id[{1}], " +
                            "ReviewId[{2}], The Actual review[{3}]";

            Console.WriteLine("");
            foreach (var review in commentReviewList)
            {
                Console.WriteLine(String.Format(format, reviewCount, review.Comment, review.CommentReview,
                                                review.Review));

                reviewCount++;
            }
            Console.WriteLine("");
        }
    }
}
