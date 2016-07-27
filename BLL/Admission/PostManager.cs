using DAL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admission
{
   public class PostManager
    {
       PostGetway postGatewayObj = new PostGetway();

       public void SavePost(Post _postObj)
        {
            postGatewayObj.SavePost(_postObj);

        }

       public void UpdatePost(Post _postObj)
        {
            postGatewayObj.UpdatePost(_postObj);

        }
  

        public void DeletePost(Post _postObj)
        {
            postGatewayObj.DeletePost(_postObj);

        }


        public List<Post> GetAllPost()
        {
            return postGatewayObj.GetAllPost();
        }

        public List<Post> LoadAllPost(int id)
        {
            return postGatewayObj.LoadAllPost(id);
        }
    }
}
