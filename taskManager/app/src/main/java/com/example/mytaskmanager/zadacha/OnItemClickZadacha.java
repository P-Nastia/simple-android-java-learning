package com.example.mytaskmanager.zadacha;

import com.example.mytaskmanager.dto.zadachi.ZadachaItemDTO;

public interface OnItemClickZadacha {
    //при натиску передається задача
    void onItemClick(ZadachaItemDTO zadacha);
}
