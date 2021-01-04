<template>
    
  <div>
    <topBanner imgUrl="/imgs/banner/个人中心.jpg" />
    <inner>
      <padTitle
        mTitle="<span style='color:#eb7c06'>VIP</span>资源下载"
        sTitle="VIP学员可获取对应课程的视频源码"
      />
      <div class="resource-list">
        <ul>
          <li v-for="resource in resourceList" :key="resource.id">
            <img :src="resource.imageUrl" alt @click="showResource" />
            <div
              class="course-cover"
              @click="clcickCourse(resource)"
              v-if="showCover(resource.id)"
            >
              <span class="first-noti cover-noti">
                <img src="/imgs/icons/lockResource.png" alt />
              </span>
              <!-- <span class="last-noti cover-noti" v-if="!isLogin"
                >{{resource.name}}</span
              > -->
              <span class="last-noti cover-noti" v-if="!isLogin">点击登录</span>
              <span class="last-noti cover-noti" v-if="isLogin">需要报名</span>
              <span class="no-login bottom-noti" v-if="!isLogin">未登录</span>
              <i>{{ resource.name }}</i>
            </div>
          </li>
        </ul>
      </div> </inner
    > 
    <div class="user-info">
      <inner>
        <padTitle mTitle="个人信息" sTitle="不一样的烟火" />
        <div class="user-info">
          <img src="/imgs/icons/userInfo.jpg" alt="" />
          <div class="user-right">
            <p>
              <span class="user-title">QQ</span>
              <span>8888888888</span>
            </p>
            <p>
              <span class="user-title">手机号码</span>
              <span>8888888888</span>
            </p>
            <p>
              <span class="user-title">昵称</span>
              <span class="can-modify">8888888888</span>
            </p>
            <p>
              <span class="user-title">密码</span>
              <span class="can-modify">8888888888</span>
            </p>
            <p>
              <span class="user-title">性别</span>
              <span class="can-modify">男</span>
              <span class="sex-modify" style="display: none">
                <label> <input type="radio" name="sex" value="0" /> 女 </label>
                <label> <input type="radio" name="sex" value="1" /> 男 </label>
                <label>
                  <input type="radio" name="sex" value="2" /> 其他
                </label>
              </span>
            </p>
            <p>
              <span class="user-title">注册时间</span>
              <span>8888888888</span>
            </p>
            <p>
              <span class="user-title">最后登录</span>
              <span>8888888888</span>
            </p>
          </div>
        </div>
      </inner>
    </div>
      <inner>
      <padTitle
        mTitle="<span style='color:#eb7c06'>寄语</span>"
        sTitle="白日莫闲过，青春不再来"
      />
      <div class="write-last">
        <pre>
            <p><span>我</span>深深的理解，耗费了多少时间，战胜了多少困难，你才取得眼前的成绩。</p>
            <p>而未来的征程里，将还有更多的艰难险阻等着你去战胜，去征服!</p>
            <p>请你相信，在你追求、拼搏和苦干的过程中，朝夕教育将永远站在你的身旁!</p>
            </pre>
      </div>
    </inner>
    <!-- <resourcePad id="resourcePad" style="display:none"/>          -->
  </div>
</template>
<script>
import resourcePad from "../components/ResourcePad";
export default {
  data() {
    return {
      resourceList: [],
      resourceIds: [],
      testList: [],
      //这里无法获取父类好像是因为data传递的问题
      isLogin: localStorage["zxToken"] != null,
      token: localStorage["zxToken"],
    };
  },
  mounted() {
    this.getResourceList();
    this.getResourceIds();
  },
  methods: {
    getResourceList() {
      this.$http
        .get("https://localhost:44385/Resource/GetResourceList")
        .then((res) => {
          this.resourceList = res.data;         
        });
    },
    getResourceIds() {
      var token = this.token;
      this.$http
        .get("https://localhost:44385/Resource/GetResourceId", {
          params: { token },
        })
        .then((res) => {
          this.resourceIds = res.data;
          console.log("res " +  res.data);
           console.log("this.resourceIds "+ typeof( this.resourceIds));
        });
    },
    clickCourse(response) {
      if (!this.isLogin) {
        this.$parent.showLoginPad("loginPad");
      } else {
        window.open(resource.lessonUrl);
      }
    },
    showResource() {
      layer.open({
        type: 1,
        title: "资源",
        shadeClose: true,
        closeBtn: 1, //0代表不显示关闭按钮
        shade: 0.3,
        skin: "layui-layer-rim", //加上边框
        area: ["398px", "352px"],
        content: $("#resourcePad"),
      });
    },
    showCover(resourceId) {
      return !this.resourceIds.includes(resourceId);
    },
  },
};
</script>
<style lang="scss" scoped>
.resource-list {
  ul {
    text-align: center;
    li {
      list-style: none;
      display: inline-block;
      margin-left: 22px;
      margin-top: 22px;
      position: relative;
      img {
        width: 368px;
        height: 216px;
      }
      .course-cover {
        width: 368px;
        height: 216px;
        background-color: rgba(0, 0, 0, 0.6);
        position: absolute;
        left: 0;
        top: 0;
        overflow: hidden;
        .cover-noti {
          height: 26px;
          display: inline-block;
          position: absolute;
          color: #fff;
          font-size: 18px;
        }
        .first-noti {
          top: -36px;
          bottom: 0;
          left: 0;
          right: 0;
          margin: auto;
          transition: top 300ms ease;
          img {
            width: 32px;
            height: 32px;
          }
        }
        .last-noti {
          top: 298px;
          bottom: 0;
          left: 0;
          right: 0;
          margin: auto;
          color: #fff;
          transition: top 300ms ease;
        }
        .bottom-noti {
          position: absolute;
          bottom: 8px;
          left: 8px;
          font-size: 16px;
          color: #f0f0f0;
        }
        i {
          height: 26px;
          position: absolute;
          top: 36px;
          bottom: 0;
          left: 0;
          right: 0;
          margin: auto;
          color: #fff;
          font-size: 22px;
          font-weight: bold;
        }
      }
      .course-cover:hover {
        .first-noti {
          top: -298px;
        }
        .last-noti {
          top: -36px;
        }
      }
    }
  }
}
.user-info {
  margin-top: 100px;
  padding-top: 60px;
  // position: 60px;
  background: #fff;
  img {
    float: left;
  }
  .user-right {
    float: left;
    text-align: left;
    margin-left: 60px;
    p {
      margin-bottom: 26px;
    }
    .user-title {
      margin-right: 36px;
    }
    .can-modify {
      cursor: pointer;
      text-decoration: underline;
    }
  }
}
.write-last {
  margin-top: 60px;
  padding-bottom: 60px;
  pre {
    font-size: 26px;
    line-height: 26px;
    width: 880px;
    margin: auto;
    margin-top: 20px;
    background-color: #fff;
    padding: 25px;
    border-radius: 50px;
    box-sizing: content-box;

    // span{
    //     font-size: 60px;
    //     color:Red;
    //     position: relative;
    //     bottom: -15px;
    // }
    p:nth-child(1):first-letter {
      font-size: 60px;
      color: Red;
      vertical-align: middle;
    }
  }
}
</style>