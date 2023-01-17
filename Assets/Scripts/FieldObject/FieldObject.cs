using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldObject : MonoBehaviour
{
    private int currentInd;
    enum Direction { UP, DOWN, LEFT, RIGHT}
    void mayGo(Direction direction)
    {
        // �÷��̾ ������ ��ġ�� Ÿ���� �ε���
        int moveInd = 0;
        if (direction == Direction.UP)
            moveInd = currentInd + 3;
        else if (direction == Direction.DOWN)
            moveInd = currentInd - 3;
        else if (direction == Direction.LEFT)
        {
            if (currentInd % 3 == 0)
                return;
            moveInd = currentInd - 1;
        }
        else if (direction == Direction.RIGHT)
        {
            if (currentInd % 3 == 2)
                return;
            moveInd = currentInd + 1;
        }

        currentInd = moveInd;
        // transform.position�� ���� ��ġ�� �Ű���� ��.
    }

}
