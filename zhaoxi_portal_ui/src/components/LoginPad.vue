<template>
      
  <div>
    <p>
      <input id="txtQQ" type="text" name="" placeholder="请输入QQ" />
    </p>
    <p>
      <input
        id="txtPwd"
        type="password"
        name=""
        placeholder="请输入朝夕登录密码"
      />
    </p>
    <p>
      <input id="txtValidate" type="text" name="" placeholder="请输入验证码" />
      <img src="" alt="验证码" />
    </p>
    <p>
      <button>登录</button>
    </p>
  </div>
</template>
<script>
export default {
    
};
</script>
<style lang="scss" scoped>
div{
    padding: 28px;
    p{
       margin-bottom: 20px;
       height: 40px;
       input{
           height: 40px;
           width: 340px;
           box-sizing: border-box;
           border-radius: 3px;
           border:1px solid #ccc;
           outline: none;
           padding: 0 6px;
       }
       button{
           width: 340px;
            box-sizing: border-box;
            height: 40px;
            border:0 none;
            background-color: rgb(255, 138, 95);
            color:#fff;
            font-size: 18px;
            outline: none;
            border-radius: 3px;
            letter-spacing: 16px;
            cursor: pointer;
       }
       button:hover{
           background-color: #f40;
       }
    }
    p:nth-child(3){
        input{
            width: 220px;
        }
    }
}
</style>