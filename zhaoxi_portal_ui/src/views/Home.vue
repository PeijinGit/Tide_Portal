<template>
  <div class="home">
    <div class="carousel" style="height:390px;with:100%;background-color:#ccc">

    </div>
    <div class="home-pad">
      <div class="home-pad-inner">
        <div class="pad-title">
          <h2>
            朝夕名师
            <span style="color:#eb7c06">在线直播</span>
          </h2>
          <h3>直播互动学习，感受技术韵律</h3>
        </div>
        <div class="public-course">
          <ul>
            <li>
            <a href="https://ke.qq.com/course/462921?taid=4259151564181577" target="_blank">
                <img src="/imgs/public/全栈体验课.jpg" alt />
                <p>全站开发，一站到底</p>
              </a>
          </li>
          <li>
            <a href="https://ke.qq.com/course/462921?taid=4259151564181577" target="_blank">
                <img src="/imgs/public/全栈体验课.jpg" alt />
                <p>全站开发，一站到底</p>
              </a>
          </li>
          <li>
            <a href="https://ke.qq.com/course/462921?taid=4259151564181577" target="_blank">
                <img src="/imgs/public/全栈体验课.jpg" alt />
                <p>全站开发，一站到底</p>
              </a>
          </li>
          <li>
            <a href="https://ke.qq.com/course/462921?taid=4259151564181577" target="_blank">
                <img src="/imgs/public/全栈体验课.jpg" alt />
                <p>全站开发，一站到底</p>
              </a>
          </li>
          <li>
            <a href="https://ke.qq.com/course/462921?taid=4259151564181577" target="_blank">
                <img src="/imgs/public/全栈体验课.jpg" alt />
                <p>全站开发，一站到底</p>
              </a>
          </li>
          </ul>
        </div>
        <div class="pad-title">
            <h2>
              朝夕6大
              <span style="color:#eb7c06">贴心服务</span>
            </h2>
            <h3>学伴式专属服务，打造IT精英圈层</h3>
        </div>
        <div class="company-service">
            <img src="/imgs/companyInfo/6大服务.png" alt="">
        </div>
      </div>
    </div>
  </div>
</template>

<script>
// @ is an alias to /src
//import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: "Home",
  // components: {
  //   HelloWorld
  // }
};
</script>
<style lang="scss" scoped>

a {
  color:#333;
  text-decoration: none;
}

.home-pad{
  padding-top: 10px;
  margin-top: 60px;
  margin-bottom: 60px;
  .home-pad-inner{
    width: 88%;
    margin: auto;
    .pad-title{
      h2{
        height: 52px;
        text-align: center;
        font-size: 35px;
      }
      h3{
        color: #909090;
        font-size: 22px;
        font-weight: normal;
        text-align: center;
        margin-top: 5px;
        height: 36px;
        line-height: 36px;
      }
    }
    .public-course{
      margin-bottom: 110px;
      ul{
        text-align: center;
        li{
          list-style: none;
          display: inline-block;
          margin-left: 36px;
          margin-top: 36px;
          img{
            width: 288px;
          }
          p{
            font-size: 14px;
            text-align: center;
            padding: 6px;
          }
        }
      }
    }
    .company-service{
      margin-top: 60px;
      text-align: center;
      margin-bottom: 116px;
    }
  }
}
</style>


