using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetNote.Models
{
    public enum BoardWriteFormType
    {
        Write,   // 글 쓰기모드
        Modify,  // 글 수정모드
        Reply    // 댓글 모드
    }

    public enum ContentEndocodingType
    {
        Text, // 일반텍스트
        Html, // HTML 입력모드
        Mixed // HTML입력 + 엔터키 모드
    }
}