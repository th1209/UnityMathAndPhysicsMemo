using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{
    void Start ()
    {
        //Basic();
        //DotProduct();
        //CrossProduct();
    }

    void Basic()
    {
        var v = new Vector3(-12f, 0f, 5f);

        Debug.Log(
            "各要素へのアクセス(代入もOK):"
            + "\nx:" + v.x
            + "\ny:" + v.y
            + "\nx:" + v.z
        );

        Debug.Log("ベクトルの大きさ:" + v.magnitude);

        // ベクトルの大きさを求める(平方根を取る)は計算量が多い。
        // そのため、単に2ベクトル間の大きさを比較したい場合、sqrMagnitudeを使う。
        Debug.Log("ベクトルの大きさの二乗:" + v.sqrMagnitude);

        // ※Normalizeメソッドを使っても取れるが、
        // こちらのメソッドは何も返さず、現在のVector3インスタンスを正規化する。
        Debug.Log("ベクトルの正規化:" + v.normalized);

        Debug.Log("ベクトルの加減:" + (new Vector3(1f, 0f, 1f) - new Vector3(0f, 1f, 0f)));

        Debug.Log("ベクトルのスケール:" + (new Vector3(1f, 2f, 0f) * 1.5f));
        Debug.Log("ベクトルのスケール:" + (new Vector3(1f, 2f, 0f) / 2f));

        // Quaternionを使って回転できる。必ずQuaternionを左辺値に取ること。
        Debug.Log("ベクトルの回転" + (Quaternion.Euler(0f, 0f, 45f) * new Vector3(1f, 0f, 0f)));
    }

    void DotProduct()
    {
        var v1 = new Vector3(5f, 2f, -3f);
        var v2 = new Vector3(8f, 1f, -4f);

        Debug.Log("ベクトルの内積:" + Vector3.Dot(v1, v2));
        Debug.Log("ベクトルのなす角:" + Vector3.Angle(v1, v2));

        // 第一引数のベクトルを、第二引数のベクトルに対し投影する。
        // 第二引数のベクトルは、正規化しておかなくてよい。
        Debug.Log("ベクトルを投影する:" + Vector3.Project(new Vector3(4f, 3f, 0f), new Vector3(2f, 0f, 0f)));
    }

    void CrossProduct()
    {
        var v1 = new Vector3(5f, -6f, 0f);
        var v2 = new Vector3(1f, 2f, 3f);

        // 外積なので、左辺値と右辺値を入れ替えた値は等しくならない。
        Debug.Log("ベクトルの外積:" + Vector3.Cross(v1, v2));
        Debug.Log("ベクトルの外積:" + Vector3.Cross(v2, v1));

        Debug.Log("2つのベクトルの面法線:" + Vector3.Cross(v1, v2).normalized);
    }
}
