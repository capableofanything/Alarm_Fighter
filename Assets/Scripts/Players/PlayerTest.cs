using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �� Ŭ������ PlayerTextŬ�����̸� FieldObject�� ��ӹ޾� ����. FieldObject�� MonoBehaviour�� ��ӹް� �ִ�. (1.17 ���� �߰�)
public class PlayerTest : FieldObject
{
    
    // Start is called before the first frame update
    void Start()
    {
        // type�� �ʱ�ȭ�ϰ� objectField�� �޾ƿ� ��, objectList�� PlayerField�� �޾ƿ´�.
        type = 1;
        objectField = Managers.Field.getField();
        objectList = objectField.getGridArray(type);
        
        currentInd = 0;
        // ��  ��ü�� ��ġ�� �ϴ��� 0 �ε����� Ÿ�Ͽ� �ʱ�ȭ
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectList[currentInd].transform.position;
    }
}
