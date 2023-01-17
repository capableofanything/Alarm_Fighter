using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
// �� Ŭ������ FieldObject�̸�, Player�� Monster���� ��ӵ� �θ� Ŭ�����̴�. (1.17 ���� �߰�)
public abstract class FieldObject : MonoBehaviour
{
    // ��� ���� �� �ֵ��� protected�� ���� ������ ����
    protected int currentInd; // ���� ��ġ�� Ÿ���� �ε��� 
    protected int type = 0; // �� FieldObject Ŭ������ ��� ���� ����Ŭ������ Ÿ�� (type : 1 -> �÷��̾� / type : 2 -> ����)
    protected Field objectField; // Scene�� ������ Field�� ���� �� �ִ� Field�� ����
    protected List<GameObject> objectList; // Field�� ���� �޾ƿ� Ÿ���� ����Ʈ -> �� Ŭ������ ��� ���� Ŭ������ Start���� �ʱ�ȭ ����.
    
    enum Direction { UP, DOWN, LEFT, RIGHT} // UP == 0, DOWN  == 1, LEFT == 2, RIGHT == 3
    // mayGo �Լ� -> �÷��̾��� ��ġ�� �Ű��ָ� direction�� �Ű������� �޴´�.
    void mayGo(Direction direction)
    {
        try
        {
            // �÷��̾ ������ ��ġ�� Ÿ���� �ε���
            int moveInd = 0;
            if (direction == Direction.UP)
                moveInd = currentInd + objectField.getWidth();
            else if (direction == Direction.DOWN)
                moveInd = currentInd - objectField.getHeight();
            else if (direction == Direction.LEFT)
            {
                if (currentInd % objectField.getWidth() == 0)
                    return;
                moveInd = currentInd - 1;
            }
            else if (direction == Direction.RIGHT)
            {
                if (currentInd % objectField.getWidth() == objectField.getWidth() - 1)
                    return;
                moveInd = currentInd + 1;
            }
            // transform.position�� ���� ��ġ�� �Ű���� ��. -> �̶� objectList�� ������ �� IndexOutOfRange�� ���´ٸ� �ű� �� ���� ��Ȳ�̹Ƿ� ���� ó��
            transform.position = objectList[moveInd].transform.position;
            currentInd = moveInd;
        }
        catch (IndexOutOfRangeException e)  // �α׸� ���, �������� ������ return
        {
            Debug.Log(e);
            return;
        }
    }
    // BitBehave() -> ��������� ��.
    void BitBehave()
    {

    }
}
