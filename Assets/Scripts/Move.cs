using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct VectorXYZ
{
    public float x, y, z;
    public VectorXYZ(float _x, float _y, float _z)
    {
        this.x = _x;
        this.y = _y;
        this.z = _z;
    }

    public VectorXYZ normalize
    {
        get
        {
            float div_coef= 1.0f / this.magnitude;
            return new VectorXYZ(this.x * div_coef, this.y * div_coef, this.z * div_coef);
        }
    }

    public float magnitude
    {
        get
        {
            return Mathf.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }
    }

    public float Dot(VectorXYZ v)
    {
        return (this.x * v.x + this.y * v.y + this.z * v.z);
    }

    public VectorXYZ CrossDot(VectorXYZ v)
    {
        return new VectorXYZ(this.y * v.z - this.z * v.y,
                             this.z * v.x - this.x * v.z,
                             this.x * v.y - this.y * v.x);
    }

    public static VectorXYZ CrossDot(VectorXYZ lhs, VectorXYZ rhs)
    {
        return new VectorXYZ(lhs.y * rhs.z - lhs.z * rhs.y,
                             lhs.z * rhs.x - lhs.x * rhs.z,
                             lhs.x * rhs.y - lhs.y * rhs.x);
    }
}
public class Move : MonoBehaviour
{
    VectorXYZ vectXYZ = new VectorXYZ(3, 4, 0);
    Vector3 vect = new Vector3(3, 4, 0);



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vect.magnitude + " " + vectXYZ.magnitude);

        VectorXYZ testNormXYZ = vectXYZ.normalize;
        Debug.Log(vect.normalized + " = (" + testNormXYZ.x + "," + testNormXYZ.y + "," + testNormXYZ.z + ")");

        Debug.Log("Dot product XYZ: " + vectXYZ.Dot(new VectorXYZ(1, 1, 1)));
        Debug.Log("Dot product: " + Vector3.Dot(vect, new Vector3(1, 1, 1)));

        VectorXYZ testCrossDotXYZ = vectXYZ.CrossDot(new VectorXYZ(1, 1, 1));
        Vector3 testCrossDot3 = Vector3.Cross(vect, new Vector3(1, 1, 1));

        Debug.Log(testCrossDotXYZ.x + " " + testCrossDotXYZ.y + " " + testCrossDotXYZ.z);
        Debug.Log(testCrossDot3.x + " " + testCrossDot3.y + " " + testCrossDot3.z);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
