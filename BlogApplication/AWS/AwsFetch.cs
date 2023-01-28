using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.AWS
{
    public class AwsFetch
    {
        public string bucketName = "blog-application";

        public async Task UploadFileAsync([FromForm] IFormFile file)
        {
            IAmazonS3 client = new AmazonS3Client("AKIAU5Q3JA63PYJ7Q7VV", "Ue68OyzyqLL2ZULWicl1Nz9CIM9tHQefWa10tlw3", Amazon.RegionEndpoint.USEast1);
            PutObjectRequest request = new PutObjectRequest
            {
                BucketName = "blog-application",
                Key = file.Name,
                InputStream = file.OpenReadStream(),
                ContentType = file.ContentType
            };
            var response = await client.PutObjectAsync(request);
        }
        
        
    }
}
