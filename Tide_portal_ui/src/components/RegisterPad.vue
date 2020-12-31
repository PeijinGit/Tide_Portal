<template>
    <div class="register-page">
        <div class="reg-pad">
            <div class="warn">用户未填写</div>
            <p>
                <i class="fa fa-user fa-2x" aria-hidden="true"></i>
                <input type="text" name="" id="" placeholder="请输入昵称">
            </p>
            <div class="warn">手机号码未填写</div>
            <p>
                <i class="fa fa-mobile fa-2x" aria-hidden="true"></i>
                <input type="text" name="" id="" placeholder="请输入手机号码">
            </p>
            <div class="warn">QQ未填写</div>
            <p>
                <i class="fa fa-qq fa-lg" aria-hidden="true"></i>
                <input type="text" name="" id="" placeholder="请输入QQ">
            </p>
             <div class="warn"></div>
            <p>
                <i class="fa fa-transgender fa-lg" aria-hidden="true"></i>
               <select>
                   <option value="0">女</option>
                   <option value="1">男</option>
                   <option value="2">其他</option>
               </select>
            </p>
            <div class="warn">密码未填写</div>
            <p>
                <i class="fa fa-lock fa-2x" aria-hidden="true"></i>
                <input type="text" name="" id="" placeholder="请输入昵称">
            </p>
            <div class="warn">两次密码不一致</div>
            <p>
                <i class="fa fa-lock fa-2x" aria-hidden="true"></i>
                <input type="text" name="" id="" placeholder="请输入昵称">
            </p>
            <p>
                <button>注册</button>
            </p>
        </div>
    </div>
</template>

<script>
    export default {
        
    }
</script>

<style lang="scss" scoped>
*{
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}
div{
.register-page{
    position: relative;
    padding: 10px 40px;
    .reg-pad{
        .warn{
            color:red;
            font-size: 13px;
            height: 20px;
            width: 300px;
            line-height: 20px;
            padding: 0 6px;
        }
        p{
            overflow: hidden;
            i{
                background-color: #eee;
                width: 56px;
                height: 45px;
                line-height: 45px;
                float: left;
                border:1px solid #ccc;
                border-right: 0 none;
                border-radius: 3px 0 0 3px;
                text-align: center;
            }
            input{
                height: 45px;
                width: 370px;
                float: left;
                border: 1px solid #ccc;
                 border-left: 0 none;
                 border-radius: 0 3px 3px 0;
                 outline: none;
                 padding: 0 6px;
            }
             select{
                height: 45px;
                width: 370px;
                float: left;
                border: 1px solid #ccc;
                 border-left: 0 none;
                 border-radius: 0 3px 3px 0;
                 outline: none;
                 padding: 0 6px;
            }
             button{
                height: 45px;
                width: 426px;
                float: left;
                background-color: rgb(255, 170, 139);
                 border: 0 none;
                 border-radius: 3px;
                 outline: none;
                 padding: 0 6px;
                 margin-top: 20px;
            }
        }
    }
}
}
</style>