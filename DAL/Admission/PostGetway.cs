using DATA;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admission
{
    public class PostGetway
    {
        SIPIDBEntities datacontextObj = new SIPIDBEntities();

        public void SavePost(Post _postObj)
        {
            var newPostObj = new POST
            {
               DistrictId = _postObj.DistrictId,

               ThanaId = _postObj.ThanaId,

               PostName = _postObj.PostName,
               PostCode = _postObj.PostCode,
               BanglaPostName = _postObj.BanglaPostName 

              
            };
            datacontextObj.POSTs.Add(newPostObj);
            datacontextObj.SaveChanges();
        }

        public void UpdatePost(Post _postObj)
        {
            var post = datacontextObj.POSTs.First(c => c.Id == _postObj.Id);
            
            post.PostName = _postObj.PostName;
            post.PostCode = _postObj.PostCode;
            post.BanglaPostName = _postObj.BanglaPostName;

            post.ThanaId = _postObj.ThanaId;
            post.DistrictId = _postObj.DistrictId;
            datacontextObj.SaveChanges();
        }

        public void DeletePost(Post _postObj)
        {
            POST post = datacontextObj.POSTs.First(c => c.Id == _postObj.Id);
            datacontextObj.POSTs.Remove(post);
            datacontextObj.SaveChanges();
        }

        
        public List<Post> GetAllPost()
        {
            datacontextObj = new SIPIDBEntities();
            List<Post> ThanaList = new List<Post>();
            foreach (var p in (from j in datacontextObj.POSTs select j).Distinct())
            {
                Post postObj = new Post();
                
                postObj.Id = p.Id;
                postObj.PostName = p.PostName;
                postObj.PostCode = p.PostCode;
                postObj.BanglaPostName = p.BanglaPostName;

                postObj.ThanaId = p.ThanaId;
                postObj.ThanaName = p.THANA.ThanaName; 

                postObj.DistrictId = p.DistrictId;
                postObj.DistrictName = p.DISTRICT.DistrictName;

                ThanaList.Add(postObj);
            }

            return ThanaList;
        }

        public List<Post> LoadAllPost(int id)
        {


            List<Post> postList = new List<Post>();

            // -1 for all categories
            if (id == -1)
            {
                foreach (var p in (from j in datacontextObj.POSTs select j).Distinct())
                {

                    Post postObj = new Post();
                    postObj.Id = p.Id;
                    postObj.PostName = p.PostName;
                    postObj.PostCode = p.PostCode;
                    postObj.BanglaPostName = p.BanglaPostName;
                    postObj.ThanaId = p.ThanaId;
                    postObj.ThanaName = p.THANA.ThanaName;

                    postObj.DistrictId = p.DistrictId;
                    postObj.DistrictName = p.DISTRICT.DistrictName;

                    postList.Add(postObj);
                }
            }

            else
            {

                foreach (var p in (from j in datacontextObj.POSTs where j.ThanaId == id select new
                                   {
                                       j.Id,
                                       j.PostName,
                                       j.PostCode,
                                       j.BanglaPostName,
                                       j.ThanaId,
                                       j.THANA.ThanaName,
                                       j.DistrictId,
                                       j.DISTRICT.DistrictName,
                                   }).Distinct())
                {
                    Post postObj = new Post();
                    postObj.Id = p.Id;
                    postObj.PostName = p.PostName;
                    postObj.PostCode = p.PostCode;
                    postObj.BanglaPostName = p.BanglaPostName;
                    postObj.ThanaId = p.ThanaId;
                    postObj.DistrictName = p.DistrictName;
                    postObj.ThanaName = p.ThanaName;
                    postObj.DistrictId = p.DistrictId;


                    postList.Add(postObj);

                }
            }

            return postList;
            
          
        }
    }
}
