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
          <li>
            <img src="/imgs/Resource/full-stack-vip.jpg" alt />
            <div class="course-cover">
              <span class="first-noti cover-noti">
                <img src="/imgs/icons/lockResource.png" alt />
              </span>
              <span class="last-noti cover-noti" style="display:none">点击登录</span>
              <span class="last-noti cover-noti">需要报名</span>
              <span class="no-login bottom-noti">未登录</span>
              <i>全栈班</i>
            </div>
          </li>
          
        </ul>
      </div>
    </inner>            
  </div>
</template>
<script>
export default {
  name: "",
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
      .course-cover{
        width: 368px;
        height: 216px;
        background-color: rgba(0, 0, 0, 0.6);
        position: absolute;
        left: 0;
        top: 0;
        overflow: hidden;       
        // .cover-noti {
        //   height: 26px;
        //   display: inline-block;
        //   position: absolute;
        //   color: #fff;
        //   font-size: 18px;
        // }
        // .first-noti {
        //   top: -36px;
        //   bottom: 0;
        //   left: 0;
        //   right: 0;
        //    margin: auto;
        //   transition: top 300ms ease;
        //   img {
        //     width: 32px;
        //     height: 32px;
        //   }
        // }
      }
    }
  }
}
</style>