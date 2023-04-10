using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public float groundSize = 10f; // Size of the ground plane
    public Material groundMaterial; // Material to use for the ground plane

    void Start()
    {
        // Create the ground plane
        GameObject ground = new GameObject("Ground");
        MeshFilter meshFilter = ground.AddComponent<MeshFilter>();
        MeshRenderer meshRenderer = ground.AddComponent<MeshRenderer>();
        MeshCollider meshCollider = ground.AddComponent<MeshCollider>();

        // Create a new mesh for the ground plane
        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[4];
        vertices[0] = new Vector3(-groundSize, 0, -groundSize);
        vertices[1] = new Vector3(-groundSize, 0, groundSize);
        vertices[2] = new Vector3(groundSize, 0, -groundSize);
        vertices[3] = new Vector3(groundSize, 0, groundSize);
        mesh.vertices = vertices;

        int[] triangles = new int[6];
        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;
        triangles[3] = 2;
        triangles[4] = 1;
        triangles[5] = 3;
        mesh.triangles = triangles;

        Vector3[] normals = new Vector3[4];
        normals[0] = Vector3.up;
        normals[1] = Vector3.up;
        normals[2] = Vector3.up;
        normals[3] = Vector3.up;
        mesh.normals = normals;

        Vector2[] uv = new Vector2[4];
        uv[0] = new Vector2(0, 0);
        uv[1] = new Vector2(0, 1);
        uv[2] = new Vector2(1, 0);
        uv[3] = new Vector2(1, 1);
        mesh.uv = uv;

        // Assign the mesh to the MeshFilter component
        meshFilter.mesh = mesh;

        // Assign the material to the MeshRenderer component
        meshRenderer.material = groundMaterial;

        // Assign the mesh to the MeshCollider component
        meshCollider.sharedMesh = mesh;
        
        // Get the material of the ground plane
         groundMaterial = ground.GetComponent<Renderer>().material;

        // Set the color of the ground material to a brown dirt color
        groundMaterial.color = new Color(0.69f, 0.42f, 0.18f);

        
    }

    public void GenerateGround()
    {
        this.Start();
        
    }
}