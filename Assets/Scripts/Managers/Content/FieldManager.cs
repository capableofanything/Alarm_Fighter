using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager
{
    private RoundField RoundField;                                                                                                                                                                                     

    public void setField(RoundField roundField) { this.RoundField = roundField; }
    // getField() -> �� ���� Field���� field ��� ������ ������ �� �ֵ��� public���� ������ �Լ� �̴�. (1.17 ���� �߰�)
    public RoundField getField() { return this.RoundField; }

    //public void WarningAttack(int[] indexs)
    //{
    //    field.WarningAttack(indexs);
    //}
    //public void Attack(int[] indexs)
    //{
    //    field.Damage(indexs);
    //}
}
