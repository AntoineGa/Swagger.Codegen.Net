﻿namespace Swagger.Codegen.Models
{
    public class RouteModel
    {
        public string Description { get; set; }

        public HttpMethod Method { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string Remarks { get; set; }

        public bool ResponseIsList { get; set; }

        public TypeModel ResponseType { get; set; }
    }
}